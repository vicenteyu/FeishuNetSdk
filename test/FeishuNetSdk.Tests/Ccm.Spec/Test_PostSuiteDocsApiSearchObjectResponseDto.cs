namespace FeishuNetSdk.Tests.Ccm.Spec;

/// <summary>
/// 测试 搜索云文档 响应体
/// <para>接口ID：6907569523177439233</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/search/document-search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fugDM4UjL4ADO14COwgTN</para>
/// </summary>
[TestClass]
public class Test_PostSuiteDocsApiSearchObjectResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "docs_entities": [
            {
                "docs_token": "shtcnLkpxnlYksumuGNZM1abcef",
                "docs_type": "sheet",
                "owner_id": "ou_b97fbe610114d9489ff3b501a71abcef",
                "title": "项目进展周报"
            },
            {
                "docs_token": "shtcnHO7UvaulkYDXCyQraabcef",
                "docs_type": "sheet",
                "owner_id": "ou_b97fbe610114d9489ff3b501a71abcef",
                "title": "项目管理十大模板"
            },
            {
                "docs_token": "shtcnO2W1D0YqKZ5TY9z3Cabcef",
                "docs_type": "sheet",
                "owner_id": "ou_b97fbe610114d9489ff3b501a71abcef",
                "title": "项目甘特图"
            },
            {
                "docs_token": "shtcnGVvAVJdohCOnmQvMNabcef",
                "docs_type": "sheet",
                "owner_id": "ou_b97fbe610114d9489ff3b501a71abcef",
                "title": "工作周计划"
            },
            {
                "docs_token": "shtcnwdKlAT243SF95pokXabcef",
                "docs_type": "sheet",
                "owner_id": "ou_b97fbe610114d9489ff3b501a71abcef",
                "title": "面试记录"
            },
            {
                "docs_token": "shtcnfgRI0jwwY0ISPSlRlabcef",
                "docs_type": "sheet",
                "owner_id": "ou_b97fbe610114d9489ff3b501a71abcef",
                "title": "工作月计划"
            },
            {
                "docs_token": "shtcnfsEaTYMVTwT0DbNolabcef",
                "docs_type": "sheet",
                "owner_id": "ou_b97fbe610114d9489ff3b501a71abcef",
                "title": "团队文件资料库"
            },
            {
                "docs_token": "shtcn3grVqPADzPt08RiFnabcef",
                "docs_type": "sheet",
                "owner_id": "ou_b97fbe610114d9489ff3b501a71abcef",
                "title": " 费用报销单"
            },
            {
                "docs_token": "shtcne3WuFpvRbSsG3SLL7abcef",
                "docs_type": "sheet",
                "owner_id": "ou_b97fbe610114d9489ff3b501a71abcef",
                "title": "费用预算表"
            },
            {
                "docs_token": "IVGMsOakbhd96It63kkc3aabcef",
                "docs_type": "sheet",
                "owner_id": "ou_b97fbe610114d9489ff3b501a71abcef",
                "title": "团建日程安排"
            }
        ],
        "has_more": true,
        "total": 59
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.Spec.PostSuiteDocsApiSearchObjectResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}