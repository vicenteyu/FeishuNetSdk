namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 删除Doc 响应体
/// <para>接口ID：6907569742383661058</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/file/delete-a-doc</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuATM2UjLwEjN14CMxYTN</para>
/// </summary>
[TestClass]
public class Test_DeleteDriveExplorerV2FileDocsByDocTokenResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"success",
    "data":
    {
        "id":"id string",
        "result":true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.DeleteDriveExplorerV2FileDocsByDocTokenResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}