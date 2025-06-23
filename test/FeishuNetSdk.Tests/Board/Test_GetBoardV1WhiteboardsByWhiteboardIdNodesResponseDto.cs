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
                    "vertical_align": "mid"
                },
                "style": {
                    "fill_opacity": 50,
                    "border_style": "solid",
                    "border_width": "narrow",
                    "border_opacity": 50,
                    "h_flip": false,
                    "v_flip": false
                },
                "image": {
                    "token": "EeSHb3qs9oSBXoxvw33bqtOsczb"
                },
                "composite_shape": {
                    "type": "circle"
                },
                "connector": {
                    "start_object": {
                        "id": "o1:1"
                    },
                    "end_object": {
                        "id": "o1:1"
                    },
                    "captions": {
                        "data": [
                            {
                                "text": "文字内容",
                                "font_weight": "regular",
                                "font_size": 14,
                                "horizontal_align": "center",
                                "vertical_align": "mid"
                            }
                        ]
                    }
                },
                "section": {
                    "title": "分区"
                },
                "table": {
                    "meta": {
                        "row_num": 3,
                        "col_num": 3
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
                                "vertical_align": "mid"
                            }
                        }
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