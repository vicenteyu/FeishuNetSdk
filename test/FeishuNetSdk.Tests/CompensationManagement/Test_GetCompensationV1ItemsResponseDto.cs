namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 批量查询薪资项 响应体
/// <para>接口ID：7314129756769779716</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/compensation-component-and-metric/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2fitem%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCompensationV1ItemsResponseDto : TestBase
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
                "name": "基本月薪",
                "description": "每月份的薪酬",
                "category_id": "7196951947268589223",
                "value_type": "money",
                "pay_off_frequency_type": "month",
                "decimal_places": 2,
                "active_status": 1,
                "i18n_names": [
                    {
                        "locale": "zh_cn",
                        "value": "中文名称"
                    }
                ],
                "i18n_descriptions": [
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.CompensationManagement.GetCompensationV1ItemsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}