// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-09-03
// ************************************************************************
// <copyright file="Test_GetBoardV1WhiteboardsByWhiteboardIdNodesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取所有节点 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Board;

/// <summary>
/// 测试 获取所有节点 响应体
/// <para>接口ID：7338460461824360449</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/board-v1/whiteboard-node/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fboard-v1%2fwhiteboard-node%2flist</para>
/// </summary>
[TestClass]
public class Test_GetBoardV1WhiteboardsByWhiteboardIdNodesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "nodes": [
            {
                "id": "o1:1",
                "type": "composite_shape",
                "parent_id": "o1:1",
                "children": [
                    "o1:1"
                ],
                "x": 100,
                "y": 100,
                "angle": 100,
                "width": 100,
                "height": 100,
                "text": {
                    "text": "文字内容",
                    "font_weight": "regular",
                    "font_size": 14,
                    "horizontal_align": "center",
                    "vertical_align": "mid",
                    "text_color": "#6db5a3",
                    "text_background_color": "#6db5a3",
                    "line_through": true,
                    "underline": true,
                    "italic": true,
                    "angle": 90
                },
                "style": {
                    "fill_color": "#6db5a3",
                    "fill_opacity": 50,
                    "border_style": "solid",
                    "border_width": "narrow",
                    "border_opacity": 50,
                    "h_flip": false,
                    "v_flip": false,
                    "border_color": "#6db5a3"
                },
                "image": {
                    "token": "EeSHb3qs9oSBXoxvw33bqtOsczb"
                },
                "composite_shape": {
                    "type": "circle"
                },
                "connector": {
                    "start": {
                        "attched_object": {
                            "id": "o1:1",
                            "snap_to": "auto",
                            "position": {
                                "x": 0.5,
                                "y": 0.5
                            }
                        },
                        "position": {
                            "x": 0.5,
                            "y": 0.5
                        },
                        "arrow_style": "line_arrow"
                    },
                    "end": {
                        "attched_object": {
                            "id": "o1:1",
                            "snap_to": "auto",
                            "position": {
                                "x": 0.5,
                                "y": 0.5
                            }
                        },
                        "position": {
                            "x": 0.5,
                            "y": 0.5
                        },
                        "arrow_style": "line_arrow"
                    },
                    "captions": {
                        "data": [
                            {
                                "text": "文字内容",
                                "font_weight": "regular",
                                "font_size": 14,
                                "horizontal_align": "center",
                                "vertical_align": "mid",
                                "text_color": "#6db5a3",
                                "text_background_color": "#6db5a3",
                                "line_through": true,
                                "underline": true,
                                "italic": true,
                                "angle": 90
                            }
                        ]
                    },
                    "shape": "straight",
                    "turning_points": [
                        {
                            "x": 0.5,
                            "y": 0.5
                        }
                    ]
                },
                "section": {
                    "title": "分区"
                },
                "table": {
                    "meta": {
                        "row_sizes": [
                            0.5
                        ],
                        "col_sizes": [
                            0.5
                        ],
                        "style": {
                            "fill_color": "#6db5a3",
                            "fill_opacity": 50,
                            "border_style": "solid",
                            "border_width": "narrow",
                            "border_opacity": 50,
                            "h_flip": false,
                            "v_flip": false,
                            "border_color": "#6db5a3"
                        },
                        "text": {
                            "text": "文字内容",
                            "font_weight": "regular",
                            "font_size": 14,
                            "horizontal_align": "center",
                            "vertical_align": "mid",
                            "text_color": "#6db5a3",
                            "text_background_color": "#6db5a3",
                            "line_through": true,
                            "underline": true,
                            "italic": true,
                            "angle": 90
                        }
                    },
                    "title": "表格",
                    "cells": [
                        {
                            "row_index": 1,
                            "col_index": 1,
                            "merge_info": {
                                "row_span": 2,
                                "col_span": 2
                            },
                            "children": [
                                "o1:1"
                            ],
                            "text": {
                                "text": "文字内容",
                                "font_weight": "regular",
                                "font_size": 14,
                                "horizontal_align": "center",
                                "vertical_align": "mid",
                                "text_color": "#6db5a3",
                                "text_background_color": "#6db5a3",
                                "line_through": true,
                                "underline": true,
                                "italic": true,
                                "angle": 90
                            },
                            "style": {
                                "fill_color": "#6db5a3",
                                "fill_opacity": 50,
                                "border_style": "solid",
                                "border_width": "narrow",
                                "border_opacity": 50,
                                "h_flip": false,
                                "v_flip": false,
                                "border_color": "#6db5a3"
                            }
                        }
                    ]
                },
                "mind_map": {
                    "parent_id": "z1:1",
                    "type": "mind_note_text"
                },
                "locked": true,
                "z_index": 1,
                "lifeline": {
                    "size": 10,
                    "type": "actor_lifeline"
                },
                "paint": {
                    "type": "marker",
                    "lines": [
                        {
                            "x": 10,
                            "y": 10
                        }
                    ],
                    "width": 7,
                    "color": "#ffffff"
                },
                "svg": {
                    "svg_code": "code"
                },
                "sticky_note": {
                    "user_id": "12345678",
                    "show_author_info": true
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Board.GetBoardV1WhiteboardsByWhiteboardIdNodesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}