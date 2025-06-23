namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取块的内容 响应体
/// <para>接口ID：7068199542315368476</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document-block/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument-block%2fget</para>
/// </summary>
[TestClass]
public class Test_GetDocxV1DocumentsByDocumentIdBlocksByBlockIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "block": {
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
        }
    },
    "msg": ""
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDocxV1DocumentsByDocumentIdBlocksByBlockIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}