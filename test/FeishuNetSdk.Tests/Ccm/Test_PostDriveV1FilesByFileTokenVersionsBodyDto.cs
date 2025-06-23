namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建文档版本 请求体
/// <para>接口ID：7156062028485033988</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file-version/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-version%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1FilesByFileTokenVersionsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "项目文档 第 1 版",
    "obj_type": "docx"
}
""";
        var result = Deserialize<FeishuNetSdk.Ccm.PostDriveV1FilesByFileTokenVersionsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}