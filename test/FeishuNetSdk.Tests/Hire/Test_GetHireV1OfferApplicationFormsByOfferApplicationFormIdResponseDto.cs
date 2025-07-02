// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-07-02
// ************************************************************************
// <copyright file="Test_GetHireV1OfferApplicationFormsByOfferApplicationFormIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取 Offer 申请表信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取 Offer 申请表信息 响应体
/// <para>接口ID：7081627245290651652</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/offer-settings/offer_application_form/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer_application_form%2fget</para>
/// </summary>
[TestClass]
public class Test_GetHireV1OfferApplicationFormsByOfferApplicationFormIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "offer_apply_form": {
            "id": "7190465990618843431",
            "name": {
                "zh_cn": "校招 Offer 申请表",
                "en_us": "campus offer application form"
            },
            "schema": {
                "id": "7080465990618843430",
                "module_list": [
                    {
                        "id": "7230465990618843432",
                        "name": {
                            "zh_cn": "基础信息模块",
                            "en_us": "basic info module"
                        },
                        "is_customized": false,
                        "active_status": 1,
                        "hint": {
                            "zh_cn": "用于填写基础信息",
                            "en_us": "use for basic info"
                        },
                        "object_list": [
                            {
                                "id": "7260465990618843426",
                                "name": {
                                    "zh_cn": "薪资总包字段",
                                    "en_us": "salary total package field"
                                },
                                "description": {
                                    "zh_cn": "用于计算薪资总包",
                                    "en_us": "use for calculate salary total package"
                                },
                                "module_id": "7230465990618843432",
                                "is_customized": true,
                                "is_required": true,
                                "active_status": 1,
                                "need_approve": true,
                                "is_sensitive": false,
                                "object_type": 3,
                                "object_type_v2":"select",
                                "config": {
                                    "options": [
                                        {
                                            "id": "7551465990618843435",
                                            "name": {
                                                "zh_cn": "全年薪资选项",
                                                "en_us": "annual salary option"
                                            },
                                            "description": {
                                                "zh_cn": "计算全年薪资",
                                                "en_us": "calculate annual salary"
                                            }
                                        }
                                    ],
                                    "object_display_config": {
                                        "display_condition": 1,
                                        "pre_object_config_list": [
                                            {
                                                "id": "7560465990618843426",
                                                "operator": 1,
                                                "value": [
                                                    "1"
                                                ]
                                            }
                                        ]
                                    }
                                }
                            }
                        ]
                    }
                ]
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1OfferApplicationFormsByOfferApplicationFormIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}