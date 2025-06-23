namespace FeishuNetSdk.Tests.Payroll;

/// <summary>
/// 测试 获取外部数据源配置信息 响应体
/// <para>接口ID：7411366924142493698</para>
/// <para>文档地址：https://open.feishu.cn/document/payroll-v1/datasource/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fpayroll-v1%2fdatasource%2flist</para>
/// </summary>
[TestClass]
public class Test_GetPayrollV1DatasourcesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true,
        "datasources": [
            {
                "code": "test_datasource__c",
                "i18n_names": [
                    {
                        "locale": "zh_cn",
                        "value": "名称",
                        "id": "723123123123123213"
                    }
                ],
                "active_status": 1,
                "fields": [
                    {
                        "code": "test__c",
                        "i18n_names": [
                            {
                                "locale": "zh_cn",
                                "value": "名称",
                                "id": "723123123123123213"
                            }
                        ],
                        "field_type": 1,
                        "active_status": 1,
                        "i18n_description": [
                            {
                                "locale": "zh_cn",
                                "value": "名称",
                                "id": "723123123123123213"
                            }
                        ],
                        "decimal_places": 1
                    }
                ],
                "i18n_description": [
                    {
                        "locale": "zh_cn",
                        "value": "名称",
                        "id": "723123123123123213"
                    }
                ],
                "data_period_type": 1
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Payroll.GetPayrollV1DatasourcesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}