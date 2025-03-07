# Embedding Markitdown into .NET Demo

这个项目展示了如何将 Markitdown 嵌入到 .NET 应用程序中，实现 PDF 文档的文本提取和处理功能。

## 项目简介

本项目使用 CSnakes.Runtime 库在 .NET 应用中嵌入 Python 脚本，并调用 Python 的 MarkItDown 库来处理 PDF 文档。主要功能包括：

- 在 C# 应用中配置并初始化 Python 环境
- 调用 Python 的 MarkItDown 库处理 PDF 文件
- 在 .NET 应用中展示处理结果

## 项目结构
```
|-- assets/             # 资源文件
|   |-- test.pdf        # 测试用的 PDF 文件
|-- dotnet/             # .NET 项目
|   |-- CSharpConsoleApp/   # C# 控制台应用程序
|   |-- embedding-markitdown-into-dotnet-demo.sln
|-- python/             # Python 代码
|   |-- demo.py         # Python 示例代码
|   |-- requirements.txt # Python 依赖项
```

## 环境依赖

- .NET 6.0+ SDK
- Python 3.9+
- MarkItDown Python 库
- Visual Studio 2022 或 Visual Studio Code

## 快速开始

### 先决条件

### 安装

1. 克隆此仓库:
   ```
   git clone https://github.com/yourusername/embedding-markitdown-into-dotnet-demo.git
   cd embedding-markitdown-into-dotnet-demo
   ```

2. 安装 Python 运行时环境:
   
   参考 [Python Docs](https://docs.python.org/3/using/index.html) 下载并安装 Python 运行时环境。

   本 Demo 使用的是 Python 3.12 版本，在 MacOS 上通过 `brew install python@3.12` 安装。

3. 在项目 python 目录下, 创建 Python 虚拟环境:
   ```
   python3 -m venv .venv
   source venv/bin/activate
   ```
   
4. 构建并运行项目:
   ```
   dotnet build
   dotnet run
   ``` 

## 许可证

此项目采用MIT许可证 - 详情请见 [LICENSE](LICENSE) 文件。
