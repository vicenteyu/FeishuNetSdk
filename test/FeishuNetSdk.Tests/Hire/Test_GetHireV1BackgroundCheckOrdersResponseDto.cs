// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetHireV1BackgroundCheckOrdersResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取背调信息列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取背调信息列表 响应体
/// <para>接口ID：7049722392477958145</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/background_check_order/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fbackground_check_order%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1BackgroundCheckOrdersResponseDto : TestBase
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
        "page_token": "eyJvZmZzZXQiOjEsInRpbWVzdGFtcCI6MTY0MDc2NTYzMjA4OCwiaWQiOm51bGx9",
        "items": [
            {
                "order_id": "7037986982531778860",
                "application_id": "6985833807195212076",
                "order_status": 2,
                "account_third_type": 1,
                "package": "基础版",
                "name": "录入的背调",
                "feedback_info_list": [
                    {
                        "id": "6930815272790114324",
                        "attachment_url": "https://feishucdn.com/staource/v1/2de04c10-5cda-4c50~?image_size=np&cutpe=&quity=&mat=g&stmat=.wp",
                        "report_preview_url": "https://feishucdn.com/preview/file/6930815272790114324/",
                        "result": "红灯",
                        "report_type": 1,
                        "create_time": "1686645425868",
                        "report_name": "张三的背调报告"
                    }
                ],
                "process_info_list": [
                    {
                        "process": "待安排",
                        "update_time": "1638359554952",
                        "en_process": "arranged"
                    }
                ],
                "upload_time": "1662476247755",
                "candidate_info": {
                    "name": "王二",
                    "mobile": "176xxxx1234",
                    "email": "xxx@abc.vom",
                    "first_name": "Ming",
                    "last_name": "Lee"
                },
                "creator_info": {
                    "user_id": "6930815272790114324"
                },
                "contactor_info": {
                    "name": "王二",
                    "mobile": "176xxxx1234",
                    "email": "xxx@abc.vom"
                },
                "begin_time": "1686297649024",
                "end_time": "1686297649024",
                "conclusion": "绿灯",
                "provider_info": {
                    "provider_id": "6930815272790114324",
                    "provider_name": {
                        "zh_cn": "测试供应商",
                        "en_us": "test provider"
                    }
                },
                "custom_field_list": [
                    {
                        "type": "text",
                        "key": "candidate_resume",
                        "name": {
                            "zh_cn": "其他备注",
                            "en_us": "Other remark"
                        },
                        "is_required": true,
                        "description": {
                            "zh_cn": "其他备注描述",
                            "en_us": "Other remarks description"
                        },
                        "options": [
                            {
                                "key": "A",
                                "name": {
                                    "zh_cn": "选项A",
                                    "en_us": "A"
                                }
                            }
                        ]
                    }
                ],
                "custom_data_list": [
                    {
                        "key": "1",
                        "value": "user input value"
                    }
                ],
                "ext_item_info_list": [
                    {
                        "id": "6930815272790114324",
                        "name": "户籍查询"
                    }
                ],
                "update_time": "1686809576215",
                "geo": "cn",
                "location_code": "CN_1",
                "remark": "候选人很优秀"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1BackgroundCheckOrdersResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}