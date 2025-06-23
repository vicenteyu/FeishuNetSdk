namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 批量查询薪资统计指标 响应体
/// <para>接口ID：7314129756769796100</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/compensation-component-and-metric/list-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2findicator%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCompensationV1IndicatorsResponseDto : TestBase
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
                "id": "7196951947228589113",
                "name": "年度现金总和",
                "value_type": "money",
                "active_status": 1,
                "i18n_names": [
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.CompensationManagement.GetCompensationV1IndicatorsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}