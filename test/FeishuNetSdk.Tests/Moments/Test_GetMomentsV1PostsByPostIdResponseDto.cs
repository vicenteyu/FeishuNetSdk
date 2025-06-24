// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetMomentsV1PostsByPostIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询帖子信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Moments;

/// <summary>
/// 测试 查询帖子信息 响应体
/// <para>接口ID：7270433540692639747</para>
/// <para>文档地址：https://open.feishu.cn/document/moments-v1/post/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmoments-v1%2fpost%2fget</para>
/// </summary>
[TestClass]
public class Test_GetMomentsV1PostsByPostIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "post": {
            "user_id": "ou_xxxxx",
            "content": "[[{\"tag\":\"text\",\"text\":\"豪华中型车…………\"},{\"tag\":\"a\",\"text\":\"查看原文\",\"href\":\"https://www.autohome.com.cn/advice/202204/1244455.html\"}]]",
            "image_key_list": [
                "暂不支持下载图片"
            ],
            "media_file_token": "该字段暂不支持使用",
            "comment_count": 1,
            "reaction_set": {
                "reactions": [
                    {
                        "type": "OK",
                        "count": 12
                    }
                ],
                "total_count": 12
            },
            "id": "6934510454161014804",
            "create_time": "2022-05-23T00:00:00+08:00",
            "media_cover_image_key": "该字段暂不支持使用",
            "category_ids": [
                "71123"
            ],
            "link": "https://applink.feishu.cn/client/moments/detail?postId=6934510454161014804",
            "user_type": 1,
            "dislike_count": 0
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Moments.GetMomentsV1PostsByPostIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}