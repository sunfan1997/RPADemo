using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RPADemo
{
    public class CodeGenerator
    {
        private CodeCompileUnit targetUnit = new CodeCompileUnit();
        private CodeTypeDeclaration targetClass = new CodeTypeDeclaration("Program");
        private static readonly string targetInstance = "engineInstance";
        private CodeEntryPointMethod main = new CodeEntryPointMethod();

        public CodeGenerator()
        {
            CodeNamespace sample = new CodeNamespace("MyCode");
            sample.Imports.Add(new CodeNamespaceImport("System"));
            targetClass.IsClass = true;
            targetClass.TypeAttributes = TypeAttributes.Public;
            sample.Types.Add(targetClass);
            targetUnit.Namespaces.Add(sample);
            targetClass.Members.Add(main);// 入口点
        }

        public void AddMethod(string name, Type returnType, string comments, CodeExpression codeExpression)
        {
            CodeMemberMethod method = new CodeMemberMethod();
            method.Attributes = MemberAttributes.Public | MemberAttributes.Override;
            method.Name = name;
            method.ReturnType = new CodeTypeReference(returnType);
            method.Comments.Add(new CodeCommentStatement(comments));
            CodeMethodReturnStatement returnStatement = new CodeMethodReturnStatement();
            returnStatement.Expression = codeExpression;
            method.Statements.Add(returnStatement);
            targetClass.Members.Add(method);
        }

        public void AddMethod(string name, Type returnType, string comments, CodeExpression codeExpression, string paraName, Type paraType)
        {
            CodeMemberMethod method = new CodeMemberMethod();
            method.Attributes = MemberAttributes.Public | MemberAttributes.Override;
            method.Name = name;
            method.ReturnType = new CodeTypeReference(returnType);
            method.Comments.Add(new CodeCommentStatement(comments));
            method.Parameters.Add(new CodeParameterDeclarationExpression(paraType, paraName));
            CodeMethodReturnStatement returnStatement = new CodeMethodReturnStatement();
            returnStatement.Expression = codeExpression;
            method.Statements.Add(returnStatement);
            targetClass.Members.Add(method);
        }

        public void AddMethod(string name, Type returnType, string comments, CodeExpression codeExpression, List<CodeParameterDeclarationExpression> parameters)
        {
            CodeMemberMethod method = new CodeMemberMethod();
            method.Attributes = MemberAttributes.Public | MemberAttributes.Override;
            method.Name = name;
            method.ReturnType = new CodeTypeReference(returnType);
            method.Comments.Add(new CodeCommentStatement(comments));
            method.Parameters.AddRange(parameters.ToArray());
            CodeMethodReturnStatement returnStatement = new CodeMethodReturnStatement();
            returnStatement.Expression = codeExpression;
            method.Statements.Add(returnStatement);
            targetClass.Members.Add(method);
        }


        public void AddAbstractMethod(string name, Type returnType, string comments)
        {
            CodeMemberMethod method = new CodeMemberMethod();
            method.Attributes = MemberAttributes.Abstract | MemberAttributes.Public;
            method.Name = name;
            method.ReturnType = new CodeTypeReference(returnType);
            method.Comments.Add(new CodeCommentStatement(comments));
            targetClass.Members.Add(method);
        }

        public void AddAbstractMethod(string name, Type returnType, string comments, string paraName, Type paraType)
        {
            CodeMemberMethod method = new CodeMemberMethod();
            method.Attributes = MemberAttributes.Abstract | MemberAttributes.Public;
            method.Name = name;
            method.ReturnType = new CodeTypeReference(returnType);
            method.Parameters.Add(new CodeParameterDeclarationExpression(paraType, paraName));
            method.Comments.Add(new CodeCommentStatement(comments));
            targetClass.Members.Add(method);
        }

        public void AddField(string name, Type fieldType)
        {
            CodeMemberField member = new CodeMemberField();
            member.Attributes = MemberAttributes.Private;
            member.Name = name;
            member.Type = new CodeTypeReference(fieldType);
            targetClass.Members.Add(member);
        }

        public void AddObject(string name, Type fieldType, string paraName)
        {
            CodeVariableDeclarationStatement obj = new CodeVariableDeclarationStatement();
            main.Statements.Add(obj);
            obj.Name = name;
            obj.Type = new CodeTypeReference(fieldType);
            obj.InitExpression = new CodeObjectCreateExpression(fieldType, new CodeVariableReferenceExpression(paraName));
        }

        public void GenerateCode()
        {
            CodeDomProvider provider = new CSharpCodeProvider();
            CodeGeneratorOptions options = new CodeGeneratorOptions();
            options.BracingStyle = "C";
            using (StreamWriter streamWriter = new StreamWriter("SampleReactorCode.cs"))
            {
                provider.GenerateCodeFromCompileUnit(targetUnit, streamWriter, options);
            }
            // 生成代码
            CodeDomProvider provider1 = CodeDomProvider.CreateProvider("cs");
            provider.GenerateCodeFromCompileUnit(targetUnit, Console.Out, null);
        }

        public static void Start()
        {
            CodeGenerator sample = new CodeGenerator();
            Test(sample);
            sample.GenerateCode();
        }

        public static void Test(CodeGenerator sample)
        {
            var methodToAdd = "Test";
            var returnType = typeof(Dictionary<string, object>);
            var paraname = "key";
            var paraType = typeof(string);
            var parTypes = new Dictionary<string, Type>() { { "no", typeof(int) }, { paraname, paraType } };

            var parameters = GenerateParameters(parTypes);
            var parArguments = GenerateParametersArguments(parTypes).ToArray();

            sample.AddMethod(methodToAdd, returnType, "This is for engine facade",
                new CodeMethodInvokeExpression(
                    new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), targetInstance),
                    methodToAdd, parArguments), parameters);
            sample.AddAbstractMethod(methodToAdd, returnType, "This is for engine base", paraname, paraType);
            sample.AddMethod(methodToAdd, returnType, "This is for local engine",
                new CodeMethodInvokeExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "scenario"),
                    methodToAdd, parArguments), parameters);
            sample.AddMethod(methodToAdd, returnType, "This is for remote engine",
                new CodeMethodInvokeExpression(
                    new CodeTypeReferenceExpression(new CodeTypeReference("HostProxy")), methodToAdd,
                    parArguments), parameters);

            var dump = parArguments.ToList();
            parameters.Insert(0, new CodeParameterDeclarationExpression(typeof(string), "engineKey"));
            dump.Insert(0, new CodeArgumentReferenceExpression("engineKey"));
            parArguments = dump.ToArray();

            sample.AddMethod(methodToAdd, returnType, "This is for host",
                new CodeMethodInvokeExpression(new CodeTypeReferenceExpression("InstanceManager"), methodToAdd, parArguments),
                parameters);

            dump.Insert(0, new CodePrimitiveExpression(methodToAdd));
            dump.Insert(0, new CodeArgumentReferenceExpression("host_name"));
            parArguments = dump.ToArray();
            sample.AddMethod(methodToAdd, returnType, "This is for host",
                new CodeMethodInvokeExpression(new CodeTypeReferenceExpression("host"), string.Format("Invoke<{0}>", returnType.ToString())
                    , parArguments), parameters);
        }

        private static List<CodeParameterDeclarationExpression> GenerateParameters(Dictionary<string, Type> parameterTypes)
        {
            return parameterTypes.Select(parameterType => new CodeParameterDeclarationExpression(parameterType.Value, parameterType.Key)).ToList();
        }
        private static List<CodeExpression> GenerateParametersArguments(Dictionary<string, Type> parameterTypes)
        {
            return parameterTypes.Select(parameterType => (CodeExpression)new CodeArgumentReferenceExpression(parameterType.Key)).ToList();
        }
    }
}
