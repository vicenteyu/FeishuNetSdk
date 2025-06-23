namespace FeishuNetSdk.Tests.Aily;

/// <summary>
/// 测试 创建数据知识 请求体
/// <para>接口ID：7441589456115892227</para>
/// <para>文档地址：https://open.feishu.cn/document/aily-v1/data-knowledge/data-knowledge-management/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2fapp-data_asset%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAilyV1AppsByAppIdDataAssetsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "connect_type": "direct",
    "source_type": "file",
    "import_knowledge_setting": {
        "chunk_setting": {
            "rule_type": "intelligent",
            "separate_type": "paragraph",
            "size": 600,
            "overlap": 10
        },
        "file": {
            "title": "文件标题",
            "token": "bb690637b49440b08f39459a2fdcd2ca",
            "content": "这是文件内容",
            "mime_type": "application/pdf",
            "url": "https://document.com/1"
        },
        "lark_doc": {
            "type": "docx",
            "token": "T8FAcuilgC1fdaxkt58vcp91xngh",
            "with_sub_docs": false
        },
        "lark_wiki_space": {
            "space_id": "798546548961351",
            "sub_docs": [
                {
                    "type": "wiki",
                    "token": "T8FAcuilgC1fdaxkt58vcp91xngh",
                    "url": "https://cdas.feishu.cn/wiki/fdisu1"
                }
            ],
            "url": "https://ai-tenant.feishu-boe.cn/wiki/space/7283525110814736404"
        },
        "lark_helpdesk": {
            "helpdesk_id": "123"
        }
    },
    "description": {
        "zh_cn": "描述"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Aily.PostAilyV1AppsByAppIdDataAssetsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}