from markitdown import MarkItDown


def test_convert_pdf(path: str):
    """
    将PDF文件转换为Markdown格式

    参数:
        path: str - PDF文件的路径

    返回:
        打印转换后的文本内容到控制台
    """
    # 初始化MarkItDown实例
    md = MarkItDown()
    # 调用convert方法将PDF转换为Markdown
    result = md.convert(path)
    return result


if __name__ == "__main__":
    # 当脚本直接运行时，调用test_convert_pdf函数
    # 使用相对路径指向测试PDF文件
    result = test_convert_pdf("../assets/test.pdf")
    # 打印转换后的文本内容
    print(result.text_content)
