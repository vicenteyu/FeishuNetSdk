namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 更新 OKR 进展记录 响应体
/// <para>接口ID：7047052132604870684</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/progress_record/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fprogress_record%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutOkrV1ProgressRecordsByProgressIdResponseDto : TestBase
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
                                    "text": "粗体更新"
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
                                    "text": "删除线更新"
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
                                    "text": "字体颜色更新"
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
                                            "url": "https://example/docx/doxcnO2Wkq0YPZQYLuJKyyOvLrh#doxcnSOui82swqk6c0o436Ak3nc"
                                        }
                                    },
                                    "text": "https://example/docx/doxcnO2Wkq0YPZQYLuJKyyOvLrh#doxcnSOui82swqk6c0o436Ak3nc"
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
                                "fileToken": "boxbcofrHwpgexwxyvgasR2kgRh",
                                "height": 372,
                                "src": "https://internal-api-okr.feishu-boe.cn/stream/api/downloadFile/?file_token=boxbcofrHwpgexwxyvgasR2kgRh&ticket=eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJ0YXJnZXRfaWQiOiI3MDQxNDMwMzc3NjQyMDgyMzIzIiwidGFyZ2V0X3R5cGUiOjMsImFjdGlvbiI6MiwiZmlsZV90b2tlbiI6ImJveGJjb2ZySHdwZ2V4d3h5dmdhc1Iya2dSaCIsInVzZXJfaWQiOiI2OTY5ODU1NTAxNzQ0ODM0MDkyIiwidGVuYW50X2lkIjoiNjg3NzUwMjY4NzYwOTQwNjk5MCIsImV4cCI6MTY0MDE1NjEyMX0.PSs94Z6ljo4e7U5cFV8dYW-bNDUOWdKXRK8B-XKruGCtKWrhsFLNKbNygUkOgHzbiPg65aSAiCaWyhh5YeX0aw",
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
        "modify_time": "1640677887499",
        "progress_id": "7046518160811425812"
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Okr.PutOkrV1ProgressRecordsByProgressIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}