namespace FeishuNetSdk.Tests.Acs.Spec;

/// <summary>
/// 测试 获取门禁记录列表 响应体
/// <para>接口ID：6979790924691996674</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/acs-v1/access_record/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2faccess_record%2flist</para>
/// </summary>
[TestClass]
public class Test_GetAcsV1AccessRecordsResponseDto : TestBase
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
                "access_record_id": "6939433228970082591",
                "user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
                "device_id": "6939433228970082593",
                "is_clock_in": true,
                "access_time": "1624520221",
                "access_type": "FA",
                "access_data": "{\"has_access_photo\":true}",
                "is_door_open": true
            }
        ],
        "page_token": "AQD9/Rn9eij9Pm39ED40/dk53s4Ebp882DYfFaPFbz00L4CMZJrqGdzNyc8BcZtDbwVUvRmQTvyMYicnGWrde9X56TgdBuS+JKiSIkdexPw=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Acs.Spec.GetAcsV1AccessRecordsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}