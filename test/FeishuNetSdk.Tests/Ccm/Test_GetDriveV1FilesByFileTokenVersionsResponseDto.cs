namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取文档版本列表 响应体
/// <para>接口ID：7156062028484984836</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file-version/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-version%2flist</para>
/// </summary>
[TestClass]
public class Test_GetDriveV1FilesByFileTokenVersionsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "name": "项目文档 第1版",
                "version": "fnJfyX",
                "parent_token": "doxbcyvqZlSc9WlHvQMlSJabcef",
                "owner_id": "694699009591869450",
                "creator_id": "694699009591869451",
                "create_time": "1660708537",
                "update_time": "1660708537",
                "status": "0",
                "obj_type": "docx",
                "parent_type": "docx"
            }
        ],
        "page_token": "CISAiM6u8vGzZhCTj5+zBhgB",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDriveV1FilesByFileTokenVersionsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}