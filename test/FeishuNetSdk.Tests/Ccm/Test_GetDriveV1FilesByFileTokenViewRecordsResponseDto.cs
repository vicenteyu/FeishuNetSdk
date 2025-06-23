namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取文件访问记录 响应体
/// <para>接口ID：7232207479622074371</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file-view_record/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-view_record%2flist</para>
/// </summary>
[TestClass]
public class Test_GetDriveV1FilesByFileTokenViewRecordsResponseDto : TestBase
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
                "viewer_id": "ou_cc19b2bfb93f8a44db4b4d6eababcef",
                "name": "zhangsan",
                "avatar_url": "https://foo.icon.com/xxxx",
                "last_view_time": "1679284285"
            }
        ],
        "page_token": "1674037112--7189934631754563585",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDriveV1FilesByFileTokenViewRecordsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}