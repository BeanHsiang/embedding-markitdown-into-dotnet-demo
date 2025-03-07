using CSnakes.Runtime;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


// 定义一个结构体，用于存储文档转换的结果
public record DocumentConvertResult(string Markdown, string Title);

class Program
{
    static void Main(string[] args)
    {
        // 创建主机构建器，用于配置应用程序
        var builder = Host.CreateDefaultBuilder(args)
            .ConfigureServices(services =>
            {
                // 设置Python脚本的目录路径
                var home = Path.Join(Environment.CurrentDirectory, "..", "..", "python");
                // 设置Python虚拟环境的路径
                var venv = Path.Join(home, ".venv");
                // 指定本地Python运行时的路径（macOS环境下）
                var python_runtime_path = "/opt/homebrew/Frameworks/Python.framework/Versions/3.12";

                // 配置Python环境
                services
                .WithPython()                          // 添加Python支持
                .WithHome(home)                        // 设置Python脚本的主目录
                .WithVirtualEnvironment(venv)          // 配置虚拟环境
                .FromFolder(python_runtime_path, "3.12")  // 从指定文件夹使用Python运行时
                // 以下是其他可选的Python运行时配置方式（被注释掉）
                // .FromNuGet("3.12.4")                // 从NuGet包获取Python运行时
                // .FromMacOSInstallerLocator("3.12")  // 使用macOS安装定位器查找Python
                // .FromEnvironmentVariable("Python3_ROOT_DIR", "3.12")  // 从环境变量获取Python路径
                .WithPipInstaller();                   // 启用pip安装器，用于安装Python包
            });

        // 构建应用程序
        var app = builder.Build();

        // 获取配置好的Python环境服务
        var env = app.Services.GetRequiredService<IPythonEnvironment>();

        // 调用Python脚本中的Demo类和TestConvertPdf方法
        var quickDemo = env.Demo();

        // 将PDF转换为Markdown并获取结果
        var result = quickDemo.TestConvertPdf("../../assets/test.pdf");

        // 打印转换结果
        Console.WriteLine(result.GetAttr("text_content"));
    }
}