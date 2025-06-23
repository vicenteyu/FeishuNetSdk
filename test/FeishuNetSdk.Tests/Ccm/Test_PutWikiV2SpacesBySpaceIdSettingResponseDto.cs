namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 更新知识空间设置 响应体
/// <para>接口ID：7023947709203824644</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space-setting/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-setting%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutWikiV2SpacesBySpaceIdSettingResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "setting": {
            "create_setting": "admin/admin_and_member",
            "security_setting": "allow/not_allow",
            "comment_setting": "allow/not_allow"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PutWikiV2SpacesBySpaceIdSettingResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}