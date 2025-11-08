// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-09-19
//
// Last Modified By : yxr
// Last Modified On : 2025-09-19
// ************************************************************************
// <copyright file="Test_PostBoardV1WhiteboardsByWhiteboardIdNodesBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建节点 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Board;

/// <summary>
/// 测试 创建节点 请求体
/// <para>接口ID：7545367804831629314</para>
/// <para>文档地址：https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/board-v1/whiteboard-node/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fboard-v1%2fwhiteboard-node%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostBoardV1WhiteboardsByWhiteboardIdNodesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "nodes": [
        {
            "id": "o1:1",
            "type": "composite_shape",
            "parent_id": "n1:1",
            "x": 100,
            "y": 100,
            "angle": 100,
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
                "angle": 90,
                "theme_text_color_code": 0,
                "theme_text_background_color_code": -1,
                "rich_text": {
                    "paragraphs": [
                        {
                            "paragraph_type": 0,
                            "elements": [
                                {
                                    "element_type": 0,
                                    "text_element": {
                                        "text": "示例文案",
                                        "text_style": {
                                            "font_weight": "bold",
                                            "font_size": 14,
                                            "text_color": "#000000",
                                            "text_background_color": "#000000",
                                            "line_through": true,
                                            "underline": false,
                                            "italic": true
                                        }
                                    },
                                    "link_element": {
                                        "herf": "https://bytedance.larkoffice.com",
                                        "text": "示例文案",
                                        "text_style": {
                                            "font_weight": "bold",
                                            "font_size": 14,
                                            "text_color": "#000000",
                                            "text_background_color": "#000000",
                                            "line_through": true,
                                            "underline": true,
                                            "italic": true
                                        }
                                    },
                                    "mention_user_element": {
                                        "user_id": "ou_da5****************dfe",
                                        "text_style": {
                                            "font_weight": "bold",
                                            "font_size": 14,
                                            "text_color": "#000000",
                                            "text_background_color": "#000000",
                                            "line_through": true,
                                            "underline": true,
                                            "italic": true
                                        }
                                    },
                                    "mention_doc_element": {
                                        "doc_url": "https://bytedance.larkoffice.com/wiki/xxxxx",
                                        "text_style": {
                                            "font_weight": "bold",
                                            "font_size": 14,
                                            "text_color": "#000000",
                                            "text_background_color": "#000000",
                                            "line_through": true,
                                            "underline": true,
                                            "italic": true
                                        }
                                    }
                                }
                            ],
                            "indent": 0,
                            "list_begin_index": 0,
                            "quote": true
                        }
                    ]
                },
                "text_color_type": 0,
                "text_background_color_type": 0
            },
            "style": {
                "fill_color": "#6db5a3",
                "fill_opacity": 50,
                "border_style": "solid",
                "border_width": "narrow",
                "border_opacity": 50,
                "h_flip": false,
                "v_flip": false,
                "border_color": "#6db5a3",
                "theme_fill_color_code": 3,
                "theme_border_color_code": 4,
                "fill_color_type": 0,
                "border_color_type": 0
            },
            "image": {
                "token": "EeSHb3qs9oSBXoxvw33bqtOsczb"
            },
            "composite_shape": {
                "type": "circle",
                "pie": {
                    "start_radial_line_angle": 30,
                    "central_angle": 40,
                    "radius": 10,
                    "sector_ratio": 1
                },
                "circular_ring": {
                    "start_radial_line_angle": 30,
                    "central_angle": 40,
                    "radius": 10,
                    "sector_ratio": 1
                }
            },
            "connector": {
                "start": {
                    "attached_object": {
                        "id": "o1:1",
                        "snap_to": "auto",
                        "position": {
                            "x": 0.5,
                            "y": 0.5
                        }
                    },
                    "position": {
                        "x": 10,
                        "y": 10
                    },
                    "arrow_style": "line_arrow"
                },
                "end": {
                    "attached_object": {
                        "id": "o1:1",
                        "snap_to": "auto",
                        "position": {
                            "x": 0.5,
                            "y": 0.5
                        }
                    },
                    "position": {
                        "x": 10,
                        "y": 10
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
                            "angle": 90,
                            "theme_text_color_code": 0,
                            "theme_text_background_color_code": -1,
                            "rich_text": {
                                "paragraphs": [
                                    {
                                        "paragraph_type": 0,
                                        "elements": [
                                            {
                                                "element_type": 0,
                                                "text_element": {
                                                    "text": "示例文案",
                                                    "text_style": {
                                                        "font_weight": "bold",
                                                        "font_size": 14,
                                                        "text_color": "#000000",
                                                        "text_background_color": "#000000",
                                                        "line_through": true,
                                                        "underline": true,
                                                        "italic": true
                                                    }
                                                },
                                                "link_element": {
                                                    "herf": "https://bytedance.larkoffice.com",
                                                    "text": "示例文案",
                                                    "text_style": {
                                                        "font_weight": "bold",
                                                        "font_size": 14,
                                                        "text_color": "#000000",
                                                        "text_background_color": "#000000",
                                                        "line_through": true,
                                                        "underline": true,
                                                        "italic": true
                                                    }
                                                },
                                                "mention_user_element": {
                                                    "user_id": "ou_da5****************dfe",
                                                    "text_style": {
                                                        "font_weight": "bold",
                                                        "font_size": 14,
                                                        "text_color": "#000000",
                                                        "text_background_color": "#000000",
                                                        "line_through": true,
                                                        "underline": true,
                                                        "italic": true
                                                    }
                                                },
                                                "mention_doc_element": {
                                                    "doc_url": "https://bytedance.larkoffice.com/wiki/xxxxx",
                                                    "text_style": {
                                                        "font_weight": "bold",
                                                        "font_size": 14,
                                                        "text_color": "#000000",
                                                        "text_background_color": "#000000",
                                                        "line_through": true,
                                                        "underline": true,
                                                        "italic": true
                                                    }
                                                }
                                            }
                                        ],
                                        "indent": 0,
                                        "list_begin_index": 0,
                                        "quote": true
                                    }
                                ]
                            },
                            "text_color_type": 0,
                            "text_background_color_type": 0
                        }
                    ]
                },
                "shape": "straight",
                "turning_points": [
                    {
                        "x": 10,
                        "y": 10
                    }
                ],
                "caption_auto_direction": true,
                "caption_position": 0.5
            },
            "width": 100,
            "section": {
                "title": "分区"
            },
            "table": {
                "meta": {
                    "row_sizes": [
                        10
                    ],
                    "col_sizes": [
                        10
                    ],
                    "style": {
                        "fill_color": "#6db5a3",
                        "fill_opacity": 50,
                        "border_style": "solid",
                        "border_width": "narrow",
                        "border_opacity": 50,
                        "h_flip": false,
                        "v_flip": false,
                        "border_color": "#6db5a3",
                        "theme_fill_color_code": 3,
                        "theme_border_color_code": 4,
                        "fill_color_type": 0,
                        "border_color_type": 0
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
                        "angle": 90,
                        "theme_text_color_code": 0,
                        "theme_text_background_color_code": -1,
                        "rich_text": {
                            "paragraphs": [
                                {
                                    "paragraph_type": 0,
                                    "elements": [
                                        {
                                            "element_type": 0,
                                            "text_element": {
                                                "text": "示例文案",
                                                "text_style": {
                                                    "font_weight": "bold",
                                                    "font_size": 14,
                                                    "text_color": "#000000",
                                                    "text_background_color": "#000000",
                                                    "line_through": true,
                                                    "underline": true,
                                                    "italic": true
                                                }
                                            },
                                            "link_element": {
                                                "herf": "https://bytedance.larkoffice.com",
                                                "text": "示例文案",
                                                "text_style": {
                                                    "font_weight": "bold",
                                                    "font_size": 14,
                                                    "text_color": "#000000",
                                                    "text_background_color": "#000000",
                                                    "line_through": true,
                                                    "underline": true,
                                                    "italic": true
                                                }
                                            },
                                            "mention_user_element": {
                                                "user_id": "ou_da5****************dfe",
                                                "text_style": {
                                                    "font_weight": "bold",
                                                    "font_size": 14,
                                                    "text_color": "#000000",
                                                    "text_background_color": "#000000",
                                                    "line_through": true,
                                                    "underline": true,
                                                    "italic": true
                                                }
                                            },
                                            "mention_doc_element": {
                                                "doc_url": "https://bytedance.larkoffice.com/wiki/xxxxx",
                                                "text_style": {
                                                    "font_weight": "bold",
                                                    "font_size": 14,
                                                    "text_color": "#000000",
                                                    "text_background_color": "#000000",
                                                    "line_through": true,
                                                    "underline": true,
                                                    "italic": true
                                                }
                                            }
                                        }
                                    ],
                                    "indent": 0,
                                    "list_begin_index": 0,
                                    "quote": true
                                }
                            ]
                        },
                        "text_color_type": 0,
                        "text_background_color_type": 0
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
                            "angle": 90,
                            "theme_text_color_code": 0,
                            "theme_text_background_color_code": -1,
                            "rich_text": {
                                "paragraphs": [
                                    {
                                        "paragraph_type": 0,
                                        "elements": [
                                            {
                                                "element_type": 0,
                                                "text_element": {
                                                    "text": "示例文案",
                                                    "text_style": {
                                                        "font_weight": "bold",
                                                        "font_size": 14,
                                                        "text_color": "#000000",
                                                        "text_background_color": "#000000",
                                                        "line_through": true,
                                                        "underline": true,
                                                        "italic": true
                                                    }
                                                },
                                                "link_element": {
                                                    "herf": "https://bytedance.larkoffice.com",
                                                    "text": "示例文案",
                                                    "text_style": {
                                                        "font_weight": "bold",
                                                        "font_size": 14,
                                                        "text_color": "#000000",
                                                        "text_background_color": "#000000",
                                                        "line_through": true,
                                                        "underline": true,
                                                        "italic": true
                                                    }
                                                },
                                                "mention_user_element": {
                                                    "user_id": "ou_da5****************dfe",
                                                    "text_style": {
                                                        "font_weight": "bold",
                                                        "font_size": 14,
                                                        "text_color": "#000000",
                                                        "text_background_color": "#000000",
                                                        "line_through": true,
                                                        "underline": true,
                                                        "italic": true
                                                    }
                                                },
                                                "mention_doc_element": {
                                                    "doc_url": "https://bytedance.larkoffice.com/wiki/xxxxx",
                                                    "text_style": {
                                                        "font_weight": "bold",
                                                        "font_size": 14,
                                                        "text_color": "#000000",
                                                        "text_background_color": "#000000",
                                                        "line_through": true,
                                                        "underline": true,
                                                        "italic": true
                                                    }
                                                }
                                            }
                                        ],
                                        "indent": 0,
                                        "list_begin_index": 0,
                                        "quote": true
                                    }
                                ]
                            },
                            "text_color_type": 0,
                            "text_background_color_type": 0
                        },
                        "style": {
                            "fill_color": "#6db5a3",
                            "fill_opacity": 50,
                            "border_style": "solid",
                            "border_width": "narrow",
                            "border_opacity": 50,
                            "h_flip": false,
                            "v_flip": false,
                            "border_color": "#6db5a3",
                            "theme_fill_color_code": 3,
                            "theme_border_color_code": 4,
                            "fill_color_type": 0,
                            "border_color_type": 0
                        }
                    }
                ]
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
                "svg_code": "<svg width=\"100\" height=\"100\"><circle cx=\"50\" cy=\"50\" r=\"40\" stroke=\"black\" stroke-width=\"2\" fill=\"red\" /></svg>"
            },
            "sticky_note": {
                "user_id": "12345678",
                "show_author_info": true
            },
            "mind_map_node": {
                "parent_id": "z1:1",
                "type": "mind_map_text",
                "z_index": 2,
                "layout_position": "left",
                "collapsed": true
            },
            "mind_map_root": {
                "layout": "left_right",
                "type": "mind_map_round_rect",
                "line_style": "round_angle"
            }
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Board.PostBoardV1WhiteboardsByWhiteboardIdNodesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}