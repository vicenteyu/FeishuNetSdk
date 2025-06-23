namespace FeishuNetSdk.Tests.Search.Spec;

/// <summary>
/// 测试 批量获取数据源 响应体
/// <para>接口ID：6953505452630261763</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/open-search/data_source/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fdata_source%2flist</para>
/// </summary>
[TestClass]
public class Test_GetSearchV2DataSourcesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": true,
        "page_token": "NqjxxDD6oV574VOicGKaK/IETyZStu8897k/f4qY",
        "items": [
            {
                "id": "6953903108179099667",
                "name": "客服工单",
                "state": 0,
                "description": "搜索客服工单数据",
                "create_time": "1618829192",
                "update_time": "1618829192",
                "is_exceed_quota": true,
                "icon_url": "https://www.xxx.com/open.jpg",
                "template": "search_common_card",
                "searchable_fields": [
                    "field1"
                ],
                "i18n_name": {
                    "zh_cn": "任务",
                    "en_us": "TODO",
                    "ja_jp": "タスク"
                },
                "i18n_description": {
                    "zh_cn": "任务",
                    "en_us": "TODO",
                    "ja_jp": "タスク"
                },
                "schema_id": "custom_schema",
                "app_id": "cli_a1306bed4738d01b"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Search.Spec.GetSearchV2DataSourcesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}