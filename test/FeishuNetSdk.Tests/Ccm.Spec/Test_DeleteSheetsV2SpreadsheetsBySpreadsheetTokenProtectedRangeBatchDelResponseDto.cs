namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 删除保护范围 响应体
/// <para>接口ID：6923123667871629340</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/protect-range/delete-protection-scopes</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYTM5YjL2ETO24iNxkjN</para>
/// </summary>
[TestClass]
public class Test_DeleteSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchDelResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "Success",
    "data": {
        "delProtectIds": [
            "6947942538267541505"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.DeleteSheetsV2SpreadsheetsBySpreadsheetTokenProtectedRangeBatchDelResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}