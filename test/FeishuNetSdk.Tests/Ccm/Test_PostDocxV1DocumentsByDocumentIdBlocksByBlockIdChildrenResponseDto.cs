namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建块 响应体
/// <para>接口ID：7068199542315270172</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document-block/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument-block-children%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostDocxV1DocumentsByDocumentIdBlocksByBlockIdChildrenResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "children": [
            {
                "block_id": "doxcnXgNGAtaAraIRVeCfmbx4Eo",
                "block_type": 2,
                "parent_id": "doxcnAJ9VRRJqVMYZ1MyKnayXWe",
                "text": {
                    "elements": [
                        {
                            "text_run": {
                                "content": "多人实时协同，插入一切元素。不仅是在线文档，更是",
                                "text_element_style": {
                                    "background_color": 14,
                                    "text_color": 5
                                }
                            }
                        },
                        {
                            "text_run": {
                                "content": "强大的创作和互动工具",
                                "text_element_style": {
                                    "background_color": 14,
                                    "bold": true,
                                    "text_color": 5
                                }
                            }
                        }
                    ],
                    "style": {}
                }
            }
        ],
        "client_token": "ea403093-3af1-4e9d-8f5d-53c5a4e4c36e",
        "document_revision_id": 148
    },
    "msg": ""
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostDocxV1DocumentsByDocumentIdBlocksByBlockIdChildrenResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}