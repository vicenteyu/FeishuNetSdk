namespace FeishuNetSdk.Tests.Ccm;

/// <summary>
/// 测试 获取文件元数据 响应体
/// <para>接口ID：7106040876741345308</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/file/batch_query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmeta%2fbatch_query</para>
/// </summary>
[TestClass]
public class Test_PostDriveV1MetasBatchQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "metas": [
            {
                "doc_token": "doccnfYZzTlvXqZIGTdAHKabcef",
                "doc_type": "doc",
                "title": "sampletitle",
                "owner_id": "ou_b13d41c02edc52ce66aaae67bf1abcef",
                "create_time": "1652066345",
                "latest_modify_user": "ou_b13d41c02edc52ce66aaae67bf1abcef",
                "latest_modify_time": "1652066345",
                "url": "https://sample.feishu.cn/docs/doccnfYZzTlvXqZIGTdAHKabcef",
                "sec_label_name": "L2-内部"
            }
        ],
        "failed_list": [
            {
                "token": "boxcnrHpsg1QDqXAAAyachabcef",
                "code": 970005
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Ccm.PostDriveV1MetasBatchQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}