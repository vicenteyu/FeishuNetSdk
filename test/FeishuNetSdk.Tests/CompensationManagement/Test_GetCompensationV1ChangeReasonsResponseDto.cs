namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 批量查询定调薪原因 响应体
/// <para>接口ID：7314129756769730564</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/compensation-setting-and-adjustment/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fchange_reason%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCompensationV1ChangeReasonsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "id": "7196951947268589113",
                "name": "入职调薪",
                "note": "入职时使用的调薪原因",
                "active_status": 1,
                "i18n_names": [
                    {
                        "locale": "zh_cn",
                        "value": "中文名称"
                    }
                ],
                "i18n_notes": [
                    {
                        "locale": "zh_cn",
                        "value": "中文名称"
                    }
                ]
            }
        ],
        "page_token": "1234452132",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.CompensationManagement.GetCompensationV1ChangeReasonsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}