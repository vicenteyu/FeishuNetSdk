// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostOkrV1ProgressRecordsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建 OKR 进展记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 创建 OKR 进展记录 响应体
/// <para>接口ID：7047048928294944770</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/progress_record/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fprogress_record%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostOkrV1ProgressRecordsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "content": {
            "blocks": [
                {
                    "paragraph": {
                        "elements": [
                            {
                                "textRun": {
                                    "style": {
                                        "bold": true
                                    },
                                    "text": "粗体验证"
                                },
                                "type": "textRun"
                            }
                        ]
                    },
                    "type": "paragraph"
                },
                {
                    "paragraph": {
                        "elements": [
                            {
                                "textRun": {
                                    "style": {
                                        "bold": true
                                    },
                                    "text": "*"
                                },
                                "type": "textRun"
                            },
                            {
                                "textRun": {
                                    "style": {
                                        "strikeThrough": true
                                    },
                                    "text": "删除线验证"
                                },
                                "type": "textRun"
                            }
                        ]
                    },
                    "type": "paragraph"
                },
                {
                    "paragraph": {
                        "elements": [
                            {
                                "textRun": {
                                    "style": {
                                        "textColor": {
                                            "alpha": 1,
                                            "blue": 49,
                                            "green": 57,
                                            "red": 216
                                        }
                                    },
                                    "text": "字体颜色验证"
                                },
                                "type": "textRun"
                            }
                        ]
                    },
                    "type": "paragraph"
                },
                {
                    "paragraph": {
                        "elements": [
                            {
                                "textRun": {
                                    "style": {
                                        "backColor": {
                                            "alpha": 1,
                                            "blue": 188,
                                            "green": 191,
                                            "red": 251
                                        }
                                    },
                                    "text": "背景颜色验证"
                                },
                                "type": "textRun"
                            }
                        ]
                    },
                    "type": "paragraph"
                },
                {
                    "paragraph": {
                        "elements": [
                            {
                                "textRun": {
                                    "style": {
                                        "backColor": {
                                            "alpha": 1,
                                            "blue": 188,
                                            "green": 191,
                                            "red": 251
                                        },
                                        "bold": true,
                                        "strikeThrough": true,
                                        "textColor": {
                                            "alpha": 1,
                                            "blue": 49,
                                            "green": 57,
                                            "red": 216
                                        }
                                    },
                                    "text": "粗体+删除+字体颜色+背景颜色验证"
                                },
                                "type": "textRun"
                            }
                        ]
                    },
                    "type": "paragraph"
                },
                {
                    "paragraph": {
                        "elements": [
                            {
                                "textRun": {
                                    "style": {},
                                    "text": "有序标题1验证，"
                                },
                                "type": "textRun"
                            },
                            {
                                "textRun": {
                                    "style": {
                                        "bold": true
                                    },
                                    "text": "粗体验证"
                                },
                                "type": "textRun"
                            }
                        ],
                        "style": {
                            "list": {
                                "indentLevel": 1,
                                "number": 1,
                                "type": "number"
                            }
                        }
                    },
                    "type": "paragraph"
                },
                {
                    "paragraph": {
                        "elements": [
                            {
                                "textRun": {
                                    "style": {},
                                    "text": "有序标题2验证，"
                                },
                                "type": "textRun"
                            },
                            {
                                "textRun": {
                                    "style": {
                                        "strikeThrough": true
                                    },
                                    "text": "删除线验证"
                                },
                                "type": "textRun"
                            }
                        ],
                        "style": {
                            "list": {
                                "indentLevel": 1,
                                "number": 2,
                                "type": "number"
                            }
                        }
                    },
                    "type": "paragraph"
                },
                {
                    "paragraph": {
                        "elements": [
                            {
                                "textRun": {
                                    "style": {},
                                    "text": "有序标题3验证，"
                                },
                                "type": "textRun"
                            },
                            {
                                "textRun": {
                                    "style": {
                                        "backColor": {
                                            "alpha": 1,
                                            "blue": 188,
                                            "green": 191,
                                            "red": 251
                                        },
                                        "textColor": {
                                            "alpha": 1,
                                            "blue": 49,
                                            "green": 57,
                                            "red": 216
                                        }
                                    },
                                    "text": "字体背景颜色验证"
                                },
                                "type": "textRun"
                            }
                        ],
                        "style": {
                            "list": {
                                "indentLevel": 1,
                                "number": 3,
                                "type": "number"
                            }
                        }
                    },
                    "type": "paragraph"
                },
                {
                    "paragraph": {
                        "elements": [
                            {
                                "textRun": {
                                    "style": {},
                                    "text": "无序标题1验证，"
                                },
                                "type": "textRun"
                            },
                            {
                                "textRun": {
                                    "style": {
                                        "bold": true
                                    },
                                    "text": "粗体"
                                },
                                "type": "textRun"
                            }
                        ],
                        "style": {
                            "list": {
                                "indentLevel": 1,
                                "type": "bullet"
                            }
                        }
                    },
                    "type": "paragraph"
                },
                {
                    "paragraph": {
                        "elements": [
                            {
                                "textRun": {
                                    "style": {},
                                    "text": "无序标题2验证，"
                                },
                                "type": "textRun"
                            },
                            {
                                "textRun": {
                                    "style": {
                                        "strikeThrough": true
                                    },
                                    "text": "删除线"
                                },
                                "type": "textRun"
                            }
                        ],
                        "style": {
                            "list": {
                                "indentLevel": 1,
                                "type": "bullet"
                            }
                        }
                    },
                    "type": "paragraph"
                },
                {
                    "paragraph": {
                        "elements": [
                            {
                                "textRun": {
                                    "style": {},
                                    "text": "无序标题3验证，"
                                },
                                "type": "textRun"
                            },
                            {
                                "textRun": {
                                    "style": {
                                        "backColor": {
                                            "alpha": 1,
                                            "blue": 188,
                                            "green": 191,
                                            "red": 251
                                        },
                                        "textColor": {
                                            "alpha": 1,
                                            "blue": 49,
                                            "green": 57,
                                            "red": 216
                                        }
                                    },
                                    "text": "字体背景颜色验证"
                                },
                                "type": "textRun"
                            }
                        ],
                        "style": {
                            "list": {
                                "indentLevel": 1,
                                "type": "bullet"
                            }
                        }
                    },
                    "type": "paragraph"
                },
                {
                    "paragraph": {
                        "elements": [
                            {
                                "textRun": {
                                    "style": {
                                        "link": {
                                            "url": "https://example.cn/docx/doxcnO2Wkq0YPZQYLuJKyyOvLrh#doxcnSOui82swqk6c0o436Ak3nc"
                                        }
                                    },
                                    "text": "https://example.cn/docx/doxcnO2Wkq0YPZQYLuJKyyOvLrh#doxcnSOui82swqk6c0o436Ak3nc"
                                },
                                "type": "textRun"
                            }
                        ]
                    },
                    "type": "paragraph"
                },
                {
                    "gallery": {
                        "imageList": [
                            {
                                "fileToken": "boxbcMTBQO9ofLjWkDuPxkxOA2c",
                                "height": 372,
                                "src": "https://internal-api-okr.feishu-boe.cn/stream/api/downloadFile/?file_token=boxbcMTBQO9ofLjWkDuPxkxOA2c&ticket=eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJ0YXJnZXRfaWQiOiI3MDQxNDMwMzc3NjQyMDgyMzIzIiwidGFyZ2V0X3R5cGUiOjMsImFjdGlvbiI6MiwiZmlsZV90b2tlbiI6ImJveGJjTVRCUU85b2ZMaldrRHVQeGt4T0EyYyIsInVzZXJfaWQiOiI2OTY5ODU1NTAxNzQ0ODM0MDkyIiwidGVuYW50X2lkIjoiNjg3NzUwMjY4NzYwOTQwNjk5MCIsImV4cCI6MTY0MDE1NTk2M30.yc4qV2pkGUVwSO53-N_XGgeMucjmDn9iso1Ez_8vpghFz8YdeSDf4NHQpxOHYHc8RURvwI0a5UTNKKJ9CWagTQ",
                                "width": 458
                            }
                        ]
                    },
                    "type": "gallery"
                },
                {
                    "paragraph": {
                        "elements": [
                            {
                                "textRun": {
                                    "style": {},
                                    "text": "任务列表未勾选验证"
                                },
                                "type": "textRun"
                            }
                        ],
                        "style": {
                            "list": {
                                "indentLevel": 1,
                                "type": "checkBox"
                            }
                        }
                    },
                    "type": "paragraph"
                },
                {
                    "paragraph": {
                        "elements": [
                            {
                                "textRun": {
                                    "style": {},
                                    "text": "任务列表已勾选验证"
                                },
                                "type": "textRun"
                            }
                        ],
                        "style": {
                            "list": {
                                "indentLevel": 1,
                                "type": "checkedBox"
                            }
                        }
                    },
                    "type": "paragraph"
                }
            ]
        },
        "modify_time": "1640675837810",
        "progress_id": "7046317985098760212"
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Okr.PostOkrV1ProgressRecordsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}