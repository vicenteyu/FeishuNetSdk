namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取云文档的点赞者列表 响应体
/// <para>接口ID：7270815553257619457</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/drive-v1/like/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIzNzUjLyczM14iM3MTN%2fdrive-v2%2ffile-like%2flist</para>
/// </summary>
[TestClass]
public class Test_GetDriveV2FilesByFileTokenLikesResponseDto : TestBase
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
                "user_id": "ou_3bbe8a09c20e89cce9bff989ed840674",
                "last_liked_time": "1690857821",
                "user_name": "张三",
                "user_en_name": "San Zhang",
                "user_avatar_url": "https://foo.icon.com/xxxx",
                "user_is_desensitized": false
            }
        ],
        "page_token": "aw7DoMKBFMOGwqHCrcO8w6jCmMOvw6ILeADCvsKNw57Di8O5XGV3LG4_w5HCqhFxSnDCrCzCn0BgZcOYUg85EMOYcEAcwqYOw4ojw5QFwofCu8KoIMO3K8Ktw4IuNMOBBHNYw4bCgCV3U1zDu8K-J8KSR8Kgw7Y0fsKZdsKvW3d9w53DnkHDrcO5bDkYwrvDisOEPcOtVFJ-I03CnsOILMOoAmLDknd6dsKqG1bClAjDuS3CvcOTwo7Dg8OrwovDsRdqIcKxw5HDohTDtXN9w5rCkWo",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDriveV2FilesByFileTokenLikesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}