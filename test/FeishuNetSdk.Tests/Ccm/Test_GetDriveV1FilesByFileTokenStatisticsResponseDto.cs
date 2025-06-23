namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取文件统计信息 响应体
/// <para>接口ID：6989584844481544196</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-statistics%2fget</para>
/// </summary>
[TestClass]
public class Test_GetDriveV1FilesByFileTokenStatisticsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "file_token": "doccnfYZzTlvXqZIGTdAHKabcef",
        "file_type": "doc",
        "statistics": {
            "uv": 10,
            "pv": 15,
            "like_count": 2,
            "timestamp": 1627367349,
            "uv_today": 1,
            "pv_today": 1,
            "like_count_today": 1
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.GetDriveV1FilesByFileTokenStatisticsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}