// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-27
// ************************************************************************
// <copyright file="I18nLanguage.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>国际化内容节点</summary>
// ************************************************************************
#pragma warning disable IDE0130 // 命名空间与文件夹结构不匹配
namespace FeishuNetSdk
#pragma warning restore IDE0130 // 命名空间与文件夹结构不匹配
{
    /// <summary>
    /// 国际化内容接口
    /// </summary>
    /// <typeparam name="T">内容类型</typeparam>
    public interface ILanguage<T>
    {
        /// <summary>
        /// 简体中文
        /// </summary>
        T? ZhCn { get; set; }

        /// <summary>
        /// 英文
        /// </summary>
        T? EnUs { get; set; }

        /// <summary>
        /// 日文
        /// </summary>
        T? JaJp { get; set; }

        /// <summary>
        /// 繁体中文（中国香港）
        /// </summary>
        T? ZhHk { get; set; }

        /// <summary>
        /// 繁体中文（中国台湾）
        /// </summary>
        T? ZhTw { get; set; }

        /// <summary>
        /// 印尼语
        /// </summary>
        T? IdId { get; set; }

        /// <summary>
        /// 越南语
        /// </summary>
        T? ViVn { get; set; }

        /// <summary>
        /// 泰语
        /// </summary>
        T? ThTh { get; set; }

        /// <summary>
        /// 葡萄牙语
        /// </summary>
        T? PtBr { get; set; }

        /// <summary>
        /// 西班牙语
        /// </summary>
        T? EsEs { get; set; }

        /// <summary>
        /// 韩语
        /// </summary>
        T? KoKr { get; set; }

        /// <summary>
        /// 德语
        /// </summary>
        T? DeDe { get; set; }

        /// <summary>
        /// 法语
        /// </summary>
        T? FrFr { get; set; }

        /// <summary>
        /// 意大利语
        /// </summary>
        T? ItIt { get; set; }

        /// <summary>
        /// 俄语
        /// </summary>
        T? RuRu { get; set; }

        /// <summary>
        /// 马来语
        /// </summary>
        T? MsMy { get; set; }

    }

    /// <summary>
    /// 国际化内容节点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public record I18nLanguage<T> : ILanguage<T>
    {
        /// <summary>
        /// 简体中文
        /// </summary>
        [JsonPropertyName("zh_cn")]
        public T? ZhCn { get; set; }

        /// <summary>
        /// 英文
        /// </summary>
        [JsonPropertyName("en_us")]
        public T? EnUs { get; set; }

        /// <summary>
        /// 日文
        /// </summary>
        [JsonPropertyName("ja_jp")]
        public T? JaJp { get; set; }

        /// <summary>
        /// 繁体中文（中国香港）
        /// </summary>
        [JsonPropertyName("zh_hk")]
        public T? ZhHk { get; set; }

        /// <summary>
        /// 繁体中文（中国台湾）
        /// </summary>
        [JsonPropertyName("zh_tw")]
        public T? ZhTw { get; set; }

        /// <summary>
        /// 印尼语
        /// </summary>
        [JsonPropertyName("id_id")]
        public T? IdId { get; set; }

        /// <summary>
        /// 越南语
        /// </summary>
        [JsonPropertyName("vi_vn")]
        public T? ViVn { get; set; }

        /// <summary>
        /// 泰语
        /// </summary>
        [JsonPropertyName("th_th")]
        public T? ThTh { get; set; }

        /// <summary>
        /// 葡萄牙语
        /// </summary>
        [JsonPropertyName("pt_br")]
        public T? PtBr { get; set; }

        /// <summary>
        /// 西班牙语
        /// </summary>
        [JsonPropertyName("es_es")]
        public T? EsEs { get; set; }

        /// <summary>
        /// 韩语
        /// </summary>
        [JsonPropertyName("ko_kr")]
        public T? KoKr { get; set; }

        /// <summary>
        /// 德语
        /// </summary>
        [JsonPropertyName("de_de")]
        public T? DeDe { get; set; }

        /// <summary>
        /// 法语
        /// </summary>
        [JsonPropertyName("fr_fr")]
        public T? FrFr { get; set; }

        /// <summary>
        /// 意大利语
        /// </summary>
        [JsonPropertyName("it_it")]
        public T? ItIt { get; set; }

        /// <summary>
        /// 俄语
        /// </summary>
        [JsonPropertyName("ru_ru")]
        public T? RuRu { get; set; }

        /// <summary>
        /// 马来语
        /// </summary>
        [JsonPropertyName("ms_my")]
        public T? MsMy { get; set; }
    }

    /// <summary>
    /// 国际化内容节点（国别地区大写）
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public record I18nLanguageUppercase<T> : ILanguage<T>
    {
        /// <summary>
        /// 简体中文
        /// </summary>
        [JsonPropertyName("zh_CN")]
        public T? ZhCn { get; set; }

        /// <summary>
        /// 英文
        /// </summary>
        [JsonPropertyName("en_US")]
        public T? EnUs { get; set; }

        /// <summary>
        /// 日文
        /// </summary>
        [JsonPropertyName("ja_JP")]
        public T? JaJp { get; set; }

        /// <summary>
        /// 繁体中文（中国香港）
        /// </summary>
        [JsonPropertyName("zh_HK")]
        public T? ZhHk { get; set; }

        /// <summary>
        /// 繁体中文（中国台湾）
        /// </summary>
        [JsonPropertyName("zh_TW")]
        public T? ZhTw { get; set; }

        /// <summary>
        /// 印尼语
        /// </summary>
        [JsonPropertyName("id_ID")]
        public T? IdId { get; set; }

        /// <summary>
        /// 越南语
        /// </summary>
        [JsonPropertyName("vi_VN")]
        public T? ViVn { get; set; }

        /// <summary>
        /// 泰语
        /// </summary>
        [JsonPropertyName("th_TH")]
        public T? ThTh { get; set; }

        /// <summary>
        /// 葡萄牙语
        /// </summary>
        [JsonPropertyName("pt_BR")]
        public T? PtBr { get; set; }

        /// <summary>
        /// 西班牙语
        /// </summary>
        [JsonPropertyName("es_ES")]
        public T? EsEs { get; set; }

        /// <summary>
        /// 韩语
        /// </summary>
        [JsonPropertyName("ko_KR")]
        public T? KoKr { get; set; }

        /// <summary>
        /// 德语
        /// </summary>
        [JsonPropertyName("de_DE")]
        public T? DeDe { get; set; }

        /// <summary>
        /// 法语
        /// </summary>
        [JsonPropertyName("fr_FR")]
        public T? FrFr { get; set; }

        /// <summary>
        /// 意大利语
        /// </summary>
        [JsonPropertyName("it_IT")]
        public T? ItIt { get; set; }

        /// <summary>
        /// 俄语
        /// </summary>
        [JsonPropertyName("ru_RU")]
        public T? RuRu { get; set; }

        /// <summary>
        /// 马来语
        /// </summary>
        [JsonPropertyName("ms_MY")]
        public T? MsMy { get; set; }
    }
}
