namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 复制文件 请求体
/// <para>接口ID：7087776630140157955</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/copy</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fcopy</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1FilesByFileTokenCopyBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "Demo copy",
    "type": "file",
    "folder_token": "fldbcO1UuPz8VwnpPx5a92abcef"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostDriveV1FilesByFileTokenCopyBodyDto>(json);
        Assert.IsNotNull(result);
    }
}