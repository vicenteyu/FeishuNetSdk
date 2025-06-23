namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 更新块的内容 响应体
/// <para>接口ID：7068199542315286556</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document-block/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument-block%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchDocxV1DocumentsByDocumentIdBlocksByBlockIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "block": {
            "block_id": "doxcnuOmySC0keKGCiPyzu29F6i",
            "block_type": 2,
            "parent_id": "doxcnAJ9VRRJqVMYZ1MyKnayXWe",
            "text": {
                "elements": [
                    {
                        "mention_user": {
                            "user_id": "ou_b828441a457cf078b7abdd4ceda99ea8"
                        }
                    },
                    {
                        "text_run": {
                            "content": "测试",
                            "text_element_style": {
                                "background_color": 2,
                                "bold": true,
                                "italic": true,
                                "strikethrough": true,
                                "text_color": 2,
                                "underline": true
                            }
                        }
                    },
                    {
                        "text_run": {
                            "content": "文本",
                            "text_element_style": {
                                "italic": true
                            }
                        }
                    },
                    {
                        "reminder": {
                            "create_user_id": "ou_b828441a457cf078b7abdd4ceda99ea8",
                            "expire_time": "1647961200000",
                            "is_notify": true,
                            "notify_time": "1647961200000"
                        }
                    }
                ],
                "style": {}
            }
        },
        "client_token": "8aac2291-bc9e-4b12-a162-b3cf15bb06bd",
        "document_revision_id": 117
    },
    "msg": ""
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PatchDocxV1DocumentsByDocumentIdBlocksByBlockIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}