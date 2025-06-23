namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 创建文档版本 响应体
/// <para>接口ID：7156062028485033988</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file-version/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-version%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1FilesByFileTokenVersionsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "name": "项目文档 第 1 版",
        "version": "fnJfyX",
        "parent_token": "doxbcyvqZlSc9WlHvQMlSJabcdf",
        "owner_id": "694699009591869450",
        "creator_id": "694699009591869451",
        "create_time": "1660708537",
        "update_time": "1660708537",
        "status": "0",
        "obj_type": "docx",
        "parent_type": "docx"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostDriveV1FilesByFileTokenVersionsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}