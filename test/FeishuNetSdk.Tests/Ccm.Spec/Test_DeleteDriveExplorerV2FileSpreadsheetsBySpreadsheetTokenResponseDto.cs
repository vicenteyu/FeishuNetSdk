namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 删除Sheet 响应体
/// <para>接口ID：6979502797244153859</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/docs/drive/file/delete-sheet</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUTNzUjL1UzM14SN1MTN%2fdelete-sheet</para>
/// </summary>
[TestClass]
public class Test_DeleteDriveExplorerV2FileSpreadsheetsBySpreadsheetTokenResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code":0,
    "msg":"Success",
    "data":
    {
        "id":"id string",
        "result":true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.DeleteDriveExplorerV2FileSpreadsheetsBySpreadsheetTokenResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}