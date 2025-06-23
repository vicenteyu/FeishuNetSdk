namespace FeishuNetSdk.Tests.Okr;

/// <summary>
/// 测试 获取 OKR 进展记录 响应体
/// <para>接口ID：7047056455665926145</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/okr-v1/progress_record/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fokr-v1%2fprogress_record%2fget</para>
/// </summary>
[TestClass]
public class Test_GetOkrV1ProgressRecordsByProgressIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "content": {
            "blocks": [
                {
                    "paragraph": {
                        "elements": [
                            {
                                "textRun": {
                                    "style": {},
                                    "text": " "
                                },
                                "type": "textRun"
                            },
                            {
                                "person": {
                                    "openId": "ou_b1ba99a5340289d7af30839fd95ce1ee",
                                    "userId": "7012194140645721644"
                                },
                                "type": "person"
                            }
                        ]
                    },
                    "type": "paragraph"
                }
            ]
        },
        "modify_time": "1640677213095",
        "progress_id": "7046518160811425812"
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Okr.GetOkrV1ProgressRecordsByProgressIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}