namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 批量获取 OKR 响应体
/// <para>接口ID：6961663213280722945</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/okr/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fokr%2fbatch_get</para>
/// </summary>
[TestClass]
public class Test_GetOkrV1OkrsBatchGetResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "okr_list": [
            {
                "confirm_status": 4,
                "id": "7072252816005349396",
                "name": "2022 年 3 月",
                "objective_list": [
                    {
                        "aligned_objective_list": [],
                        "aligning_objective_list": [],
                        "content": "需求@刘三",
                        "deadline": "1648656000000",
                        "id": "7073360513731690515",
                        "kr_list": [
                            {
                                "content": "1111@张三9",
                                "deadline": "1648656000000",
                                "id": "7073360471990140948",
                                "kr_weight": 50,
                                "mentioned_user_list": [
                                    {
                                        "open_id": "ou_a79faffdb6aee3618f0da4d42b192466",
                                        "user_id": "ou_a79faffdb6aee3618f0da4d42b192466"
                                    }
                                ],
                                "progress_rate": {
                                    "percent": 60,
                                    "status": "1"
                                },
                                "progress_rate_percent_last_updated_time": "1646907176099",
                                "progress_rate_status_last_updated_time": "1646907176099",
                                "progress_record_last_updated_time": "1646907586253",
                                "progress_record_list": [
                                    {
                                        "id": "7073411057431199764"
                                    },
                                    {
                                        "id": "7073410950174392340"
                                    },
                                    {
                                        "id": "7073360480580010004"
                                    },
                                    {
                                        "id": "7073360513731805203"
                                    }
                                ],
                                "progress_report_last_updated_time": "0",
                                "score": 100,
                                "score_last_updated_time": "1646907586244",
                                "weight": 50
                            }
                        ],
                        "mentioned_user_list": [
                            {
                                "open_id": "ou_ab08720df94e64045cc8c2b7694ef2a0",
                                "user_id": "ou_ab08720df94e64045cc8c2b7694ef2a0"
                            }
                        ],
                        "permission": 1,
                        "progress_rate": {
                            "percent": 30,
                            "status": "0"
                        },
                        "progress_rate_percent_last_updated_time": "1646907261326",
                        "progress_rate_status_last_updated_time": "1646907261326",
                        "progress_record_last_updated_time": "1646907590448",
                        "progress_record_list": [
                            {
                                "id": "7073410950447120403"
                            },
                            {
                                "id": "7073410950174474260"
                            },
                            {
                                "id": "7073360502990094355"
                            },
                            {
                                "id": "7073360502990061587"
                            }
                        ],
                        "progress_report": "红豆泥",
                        "progress_report_last_updated_time": "1646907387911",
                        "score": 100,
                        "score_last_updated_time": "1646907590472",
                        "weight": 40
                    }
                ],
                "period_id": "7067724095781142548",
                "permission": 1
            }
        ]
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Okr.GetOkrV1OkrsBatchGetResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}