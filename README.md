# 计算机课程作业档案

用于保存和跨设备同步课程练习。各目录是独立作业，使用不同的语言、框架和环境，没有统一的一键运行入口。

## 目录与入口

| 目录 | 内容 | 如何打开 |
| --- | --- | --- |
| [`DA/`](DA/) | C++ 课程练习与实验输入 | 查看 `project1/program1.cpp`、`project2/project2.cpp` 及实验数据；按各练习要求编译 |
| [`Midia/`](Midia/) | HTML、JavaScript 与图片资源 | 用浏览器打开 `work1.html` 或 `work2.html`，保留相对资源目录 |
| [`NET/`](NET/) | C#、WinForms、.NET MAUI 与串口界面示例 | 按下方具体解决方案选择环境 |
| [`WEB/`](WEB/) | CSS 练习片段 | 当前仅样式文件，不是独立 Web 应用 |

目录名称保留原课程组织方式，`Midia` 为仓库实际目录名。

## .NET 项目

### WinForms：.NET 8 / Windows

安装 .NET 8 SDK，在 Windows 终端从仓库根目录运行：

```powershell
dotnet run --project NET/program2/winForms/WinFormsApp1/WinFormsApp1/WinFormsApp1.csproj
```

也可以用 Visual Studio 打开 [`WinFormsApp1.sln`](NET/program2/winForms/WinFormsApp1/WinFormsApp1.sln)。WinForms 使用 Windows 桌面环境，不能在 macOS/Linux 上直接体验其窗口。

### MAUI：按目标平台安装工作负载

打开 [`Maui_lapy.sln`](NET/program2/MAUI_Lappand/Maui_lapy/Maui_lapy.sln)。工程目标为 .NET 8 的 Android、iOS、Mac Catalyst，Windows 主机另包含 Windows 目标；各平台需要对应 SDK、工作负载及设备环境。它不是普通控制台项目，不能把其他 WinForms 项目的运行命令套用到这里。

### Arduino 串口界面示例

[`arduinoSample.sln`](NET/program2/arduinoSample/arduinoSample.sln) 是旧式 .NET Framework 4.0 Client Profile 工程，使用 Windows/Visual Studio 对应的目标框架组件。实际串口交互还需要匹配的设备、端口和程序；本仓不保证能用最新 SDK 直接构建旧工程。

## 内容与生成文件

源码、工程文件、表单资源、实验输入与必要图片保留版本记录。`bin/`、`obj/`、本机 IDE 缓存及用户配置由各自工具重新生成，不作为跨设备传递应用的方式。需要交付可执行程序时应单独构建并注明目标系统，不混入源码目录。

课程输入与项目资源各有上下文，不能仅从文件夹名推断全部练习已经完成或通过测试。本仓没有统一测试套件，也未提供根许可证文件。
