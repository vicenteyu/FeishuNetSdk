// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-11-28
//
// Last Modified By : yxr
// Last Modified On : 2025-11-28
// ************************************************************************
// <copyright file="Test_GetCorehrV2SignatureTemplateInfoWithThumbnailsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取电子签模板列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 获取电子签模板列表 响应体
/// <para>接口ID：7376163028442824732</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/siganture/signature_template_info_with_thumbnail/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fsignature_template_info_with_thumbnail%2flist</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2SignatureTemplateInfoWithThumbnailsResponseDto : TestBase
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
                "id": "1",
                "label": [
                    {
                        "lang": "zh-CN",
                        "value": "张三"
                    }
                ],
                "category": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ]
                },
                "usage": {
                    "enum_name": "phone_type",
                    "display": [
                        {
                            "lang": "zh-CN",
                            "value": "张三"
                        }
                    ]
                },
                "create_time": "2021-12-21",
                "modify_time": "2021-12-21",
                "created_by": {
                    "id": "7300476612163913260"
                },
                "updated_by": {
                    "id": "7300476612163913260"
                },
                "thumbnail_url": "1",
                "signatory_labels": [
                    {
                        "template_signatory_type": {
                            "enum_name": "phone_type",
                            "display": [
                                {
                                    "lang": "zh-CN",
                                    "value": "张三"
                                }
                            ]
                        },
                        "label": [
                            {
                                "lang": "zh-CN",
                                "value": "张三"
                            }
                        ],
                        "apiname": "status"
                    }
                ],
                "template_code": "1234",
                "template_desc": "desc",
                "template_region_info": {
                    "is_global_scope": "global",
                    "meta_infos": [
                        {
                            "api_name": "status",
                            "wk_id": "123124124124123",
                            "label": [
                                {
                                    "lang": "zh-CN",
                                    "value": "张三"
                                }
                            ]
                        }
                    ]
                }
            }
        ],
        "page_token": 1000,
        "count": 1000
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2SignatureTemplateInfoWithThumbnailsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}