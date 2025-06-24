// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchDocxV1DocumentsByDocumentIdBlocksBatchUpdateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量更新块的内容 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 批量更新块的内容 响应体
/// <para>接口ID：7100866542866530308</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document-block/batch_update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument-block%2fbatch_update</para>
/// </summary>
[TestClass]
public class Test_PatchDocxV1DocumentsByDocumentIdBlocksBatchUpdateResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "blocks": [
            {
                "block_id": "doxcn0K8iGSMW4Mqgs9qlyTP50d",
                "block_type": 2,
                "parent_id": "doxcnAJ9VRRJqVMYZ1MyKnayXWe",
                "text": {
                    "elements": [
                        {
                            "text_run": {
                                "content": "Hello",
                                "text_element_style": {
                                    "background_color": 2,
                                    "bold": true,
                                    "inline_code": false,
                                    "italic": true,
                                    "strikethrough": true,
                                    "text_color": 2,
                                    "underline": true
                                }
                            }
                        },
                        {
                            "text_run": {
                                "content": "World ",
                                "text_element_style": {
                                    "bold": false,
                                    "inline_code": false,
                                    "italic": true,
                                    "strikethrough": false,
                                    "underline": false
                                }
                            }
                        },
                        {
                            "mention_doc": {
                                "obj_type": 22,
                                "title": "Demo",
                                "token": "doxcnAJ9VRRJqVMYZ1MyKnayXWe",
                                "url": "https%3A%2F%2Ftest.feishu.cn%2Fdocx%2FdoxcnAJ9VRRJqVMYZ1MyKnayXWe"
                            }
                        }
                    ],
                    "style": {
                        "done": false,
                        "folded": false,
                        "wrap": false
                    }
                }
            },
            {
                "block_id": "doxcnk0i44OMOaouw8AdXuXrp6b",
                "block_type": 31,
                "children": [
                    "doxcnO2UeYco4mu80sr6oRCiRpf",
                    "doxcnaAGMYMk6kcGeYXNfc1Rluc",
                    "doxcnCKuqMQOM0gAOYfysUgZD2d",
                    "doxcnMKg8Uk8wiAMIW8omQ06uoc"
                ],
                "parent_id": "doxcnAJ9VRRJqVMYZ1MyKnayXWe",
                "table": {
                    "cells": [
                        "doxcnO2UeYco4mu80sr6oRCiRpf",
                        "doxcnaAGMYMk6kcGeYXNfc1Rluc",
                        "doxcnCKuqMQOM0gAOYfysUgZD2d",
                        "doxcnMKg8Uk8wiAMIW8omQ06uoc"
                    ],
                    "property": {
                        "column_size": 2,
                        "column_width": [
                            100,
                            100
                        ],
                        "merge_info": [
                            {
                                "col_span": 2,
                                "row_span": 1
                            },
                            {
                                "col_span": 1,
                                "row_span": 1
                            },
                            {
                                "col_span": 1,
                                "row_span": 1
                            },
                            {
                                "col_span": 1,
                                "row_span": 1
                            }
                        ],
                        "row_size": 2
                    }
                }
            }
        ],
        "client_token": "e472907a-9ddc-4453-af28-22a6530b76b9",
        "document_revision_id": 387
    },
    "msg": ""
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PatchDocxV1DocumentsByDocumentIdBlocksBatchUpdateResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}