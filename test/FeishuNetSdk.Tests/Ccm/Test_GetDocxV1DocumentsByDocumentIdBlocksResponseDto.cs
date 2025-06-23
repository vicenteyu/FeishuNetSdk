namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取文档所有块 响应体
/// <para>接口ID：7068199542315352092</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument-block%2flist</para>
/// </summary>
[TestClass]
public class Test_GetDocxV1DocumentsByDocumentIdBlocksResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "has_more": false,
        "items": [
            {
                "block_id": "doxcnAJ9VRRJqVMYZ1MyKnayXWe",
                "block_type": 1,
                "children": [
                    "doxcnC4cO4qUui6isgnpofh5edc",
                    "doxcn4w8uwwoycMOqw1jRxL0qyb",
                    "doxcnc2UgKK6ssQW0sbUuli1kte",
                    "doxcnIaciiikamkwaMTLWsWntQf"
                ],
                "page": {
                    "elements": [
                        {
                            "text_run": {
                                "content": "云文档",
                                "text_element_style": {}
                            }
                        }
                    ],
                    "style": {}
                },
                "parent_id": ""
            },
            {
                "block_id": "doxcnC4cO4qUui6isgnpofh5edc",
                "block_type": 2,
                "parent_id": "doxcnAJ9VRRJqVMYZ1MyKnayXWe",
                "text": {
                    "elements": [
                        {
                            "text_run": {
                                "content": "云文档：专为协作而生",
                                "text_element_style": {
                                    "link": {
                                        "url": "https%3A%2F%2Fbytedance.feishu.cn%2Fdrive%2Fhome%2F"
                                    }
                                }
                            }
                        }
                    ],
                    "style": {}
                }
            },
            {
                "block_id": "doxcn4w8uwwoycMOqw1jRxL0qyb",
                "block_type": 2,
                "parent_id": "doxcnAJ9VRRJqVMYZ1MyKnayXWe",
                "text": {
                    "elements": [
                        {
                            "text_run": {
                                "content": "多人实时协同，插入一切元素。不仅是在线文档，更是",
                                "text_element_style": {
                                    "background_color": 15,
                                    "text_color": 5
                                }
                            }
                        },
                        {
                            "text_run": {
                                "content": "强大的创作和互动工具",
                                "text_element_style": {
                                    "background_color": 15,
                                    "bold": true,
                                    "text_color": 5
                                }
                            }
                        }
                    ],
                    "style": {}
                }
            },
            {
                "block_id": "doxcnc2UgKK6ssQW0sbUuli1kte",
                "block_type": 2,
                "parent_id": "doxcnAJ9VRRJqVMYZ1MyKnayXWe",
                "text": {
                    "style": {}
                }
            },
            {
                "block_id": "doxcnIaciiikamkwaMTLWsWntQf",
                "block_type": 2,
                "parent_id": "doxcnAJ9VRRJqVMYZ1MyKnayXWe",
                "text": {
                    "style": {}
                }
            }
        ]
    },
    "msg": ""
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDocxV1DocumentsByDocumentIdBlocksResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}