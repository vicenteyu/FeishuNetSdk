// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-09-19
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
                },
                "image": {
                    "token": "EeSHb3qs9oSBXoxvw33bqtOsczb"
                },
                "composite_shape": {
                    "type": "circle",
                    "pie": {
                        "start_radial_line_angle": 30.0,
                        "central_angle": 40.0,
                        "radius": 10,
                        "sector_ratio": 1
                    },
                    "circular_ring": {
                        "start_radial_line_angle": 30.0,
                        "central_angle": 40.0,
                        "radius": 10,
                        "sector_ratio": 1
                    }
                },
                "connector": {
                    "start_object": {
                        "id": "o1:1",
                        "snap_to": "auto",
                        "position": {
                            "x": 10,
                            "y": 10
                        }
                    },
                    "end_object": {
                        "id": "o1:1",
                        "snap_to": "auto",
                        "position": {
                            "x": 10,
                            "y": 10
                        }
                    },
                    "start": {
                        "attached_object": {
                            "id": "o1:1",
                            "snap_to": "auto",
                            "position": {
                                "x": 10,
                                "y": 10
                            }
                        },
                        "position": {
                            "x": 0.5,
                            "y": 0.5
                        },
                        "arrow_style": "line_arrow"
                    },
                    "end": {
                        "attached_object": {
                            "id": "o1:1",
                            "snap_to": "auto",
                            "position": {
                                "x": 10,
                                "y": 10
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
                            "x": 0.5,
                            "y": 0.5
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
                        "row_num": 3,
                        "col_num": 2,
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
                            "border_width": "bold",
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
                    "svg_code": "code"
                },
                "sticky_note": {
                    "user_id": "1234237",
                    "show_author_info": true
                },
                "mind_map_node": {
                    "parent_id": "12345678",
                    "type": "true",
                    "z_index": 2,
                    "layout_position": "left",
                    "children": [
                        "z2:3"
                    ],
                    "collapsed": true
                },
                "mind_map_root": {
                    "layout": "left_right",
                    "type": "mind_map_text",
                    "line_style": "rounf_angle",
                    "up_children": [
                        "z1:1"
                    ],
                    "down_children": [
                        "z2:1"
                    ],
                    "left_children": [
                        "z3:1"
                    ],
                    "right_children": [
                        "z4:1"
                    ]
                },
                "mind_map": {
                    "parent_id": "z1:1"
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