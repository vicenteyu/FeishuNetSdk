namespace FeishuNetSdk.Tests.Application.Spec;

/// <summary>
/// 测试 获取当前设置的推荐规则列表 响应体
/// <para>接口ID：7148673650311643139</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/workplace-v1/app_recommend_rule/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapp_recommend_rule%2flist</para>
/// </summary>
[TestClass]
public class Test_GetApplicationV6AppRecommendRulesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "rules": [
            {
                "id": "7137896480337641492",
                "name": "管理员小白的推荐规则",
                "status": "open",
                "visibility_info": {
                    "is_all": true,
                    "department_ids": [
                        "od-fef5204d44fa03fad66278cb8e8036e4"
                    ],
                    "user_ids": [
                        "ou_35101d538d5b3ad10a5f3480f4c27972"
                    ],
                    "group_ids": [
                        "7137608198773686291"
                    ]
                },
                "recommend_item_infos": [
                    {
                        "item_id": "7137896480337625108",
                        "item_type": "application",
                        "name": "审批",
                        "description": "审批应用的描述",
                        "link_url": "http://www.example.com",
                        "client_id": "cli_a274440757b8901c",
                        "icon_url": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v2_6150f3c3-ceee-453e-a1ae-7c11d7f13edj~?image_size=&cut_type=&quality=&format=&sticker_format=.webp",
                        "default_locale": "zh_cn",
                        "i18n_name": {
                            "zh_cn": "审批",
                            "zh_hk": "審批",
                            "zh_tw": "審批",
                            "en_us": "Approval",
                            "ja_jp": "承認"
                        }
                    }
                ],
                "distributed_recommend_item_infos": [
                    {
                        "item_id": "7137896480337625108",
                        "item_type": "application",
                        "name": "审批",
                        "description": "审批应用的描述",
                        "link_url": "http://www.example.com",
                        "client_id": "cli_a274440757b8901c",
                        "icon_url": "https://internal-api-lark-file.feishu-boe.cn/static-resource/v1/v2_6150f3c3-ceee-453e-a1ae-7c11d7f13edj~?image_size=&cut_type=&quality=&format=&sticker_format=.webp",
                        "default_locale": "zh_cn",
                        "i18n_name": {
                            "zh_cn": "审批",
                            "zh_hk": "審批",
                            "zh_tw": "審批",
                            "en_us": "Approval",
                            "ja_jp": "承認"
                        }
                    }
                ]
            }
        ],
        "page_token": "new-e11ee058b4a8ed2881da11ac7e37c4fc",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Application.Spec.GetApplicationV6AppRecommendRulesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}