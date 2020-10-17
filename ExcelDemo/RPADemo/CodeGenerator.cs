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
        private CodeNamespace sample;

        public CodeGenerator()
        {
            sample = new CodeNamespace("MyCode");
            sample.Imports.Add(new CodeNamespaceImport("System"));
            sample.Imports.Add(new CodeNamespaceImport($"{nameof(System)}.{nameof(System.Windows)}.{nameof(System.Windows.Forms)}"));
            sample.Imports.Add(new CodeNamespaceImport("RPADemo"));

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

        public void AddMethod(string name,string method,string x1,string x2)
        {
            CodeMethodInvokeExpression invokeexp = new CodeMethodInvokeExpression(new CodeTypeReferenceExpression(name),method, new CodeVariableReferenceExpression(x1), new CodeVariableReferenceExpression(x2));
            CodeExpressionStatement invrunstatem = new CodeExpressionStatement(invokeexp);
            //CodeMethodInvokeExpression invokeexp1 = new CodeMethodInvokeExpression(new CodeTypeReferenceExpression(cvds.Name), nameof(ExcelHelper.CreateFile),new CodePrimitiveExpression(@"D:\visual studio project\Demo01\Demo01\bin\Debug"));
            //CodeExpressionStatement invrunstatem1 = new CodeExpressionStatement(invokeexp1);
            main.Statements.Add(invrunstatem);
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

            // 编译
            CompilerParameters p = new CompilerParameters();
            p.GenerateExecutable = true; //生成exe
            p.CompilerOptions = "/t:winexe"; //非控制台应用程序
            p.OutputAssembly = "testapp.exe";
            // 包含入口点的类
            p.MainClass = $"{sample.Name}.{targetClass.Name}";
            // 引用的程序集
            p.ReferencedAssemblies.Add("System.dll");
            p.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            // p.ReferencedAssemblies.Add("ExcelHelper.cs");
            p.ReferencedAssemblies.Add("RPADemo.exe");

            CompilerResults res = provider.CompileAssemblyFromDom(p, targetUnit);
            if (res.Errors.Count == 0)
            {
                Console.WriteLine("编译成功。");
                // 启动它
                System.Diagnostics.Process.Start(res.CompiledAssembly.Location);
            }
            else
            {
                Console.WriteLine("错误信息：");
                foreach (CompilerError er in res.Errors)
                {
                    Console.WriteLine(er.ErrorText);
                }
            }
        }

        public  void Start(CodeGenerator sample)
        {
            //CodeGenerator sample = new CodeGenerator();
            // Test(sample);
            //main.Statements.Add(new CodeMethodInvokeExpression(new CodeMethodReferenceExpression(new CodeTypeReferenceExpression(typeof(Console)), nameof(Console.WriteLine)), new CodePrimitiveExpression("大于2。")));
            sample.GenerateCode();
        }

       
    }
}
