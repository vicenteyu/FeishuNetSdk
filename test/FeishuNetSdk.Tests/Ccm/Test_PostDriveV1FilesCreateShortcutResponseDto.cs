namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建文件快捷方式 响应体
/// <para>接口ID：7216001760515112961</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/create_shortcut</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fcreate_shortcut</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1FilesCreateShortcutResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "succ_shortcut_node": {
            "token": "doxbcGvhSVN0R6octqPwAEabcef",
            "name": "快捷方式名称",
            "type": "docx",
            "parent_token": "fldbc5qgwyQnO0uedNllWuabcef",
            "url": "https://example.feishu.cn/docx/doxbcGvhSVN0R6octqPwAEabcef",
            "shortcut_info": {
                "target_type": "docx",
                "target_token": "doxbcGvhSVN0R6octqPwAEabcef"
            },
            "created_time": "1686125119",
            "modified_time": "1686125119",
            "owner_id": "ou_b13d41c02edc52ce66aaae67bf1abcef"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostDriveV1FilesCreateShortcutResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}