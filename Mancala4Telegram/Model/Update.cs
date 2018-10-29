//using System.Collections.Generic;
//using System.Runtime.Serialization;

//namespace Mancala4Telegram
//{
//    [DataContract]
//    public class User
//    {
//        [DataMember]
//        public long id { get; set; }
//        [DataMember]
//        public bool is_bot { get; set; }
//        [DataMember]
//        public string first_name { get; set; }
//        [DataMember]
//        public string last_name { get; set; }
//        [DataMember]
//        public string username { get; set; }
//        [DataMember]
//        public string language_code { get; set; }

//    }

//    [DataContract]
//    public class Chat
//    {
//        [DataMember]
//        public long id { get; set; }
//        [DataMember]
//        public string first_name { get; set; }
//        [DataMember]
//        public string last_name { get; set; }
//        [DataMember]
//        public string username { get; set; }
//    }

//    [DataContract]
//    public class Audio
//    {
//        [DataMember]
//        public string file_id { get; set; }
//        [DataMember]
//        public long duration { get; set; }
//        [DataMember]
//        public string performer { get; set; }
//        [DataMember]
//        public string title { get; set; }
//        [DataMember]
//        public string mime_type { get; set; }
//        [DataMember]
//        public long file_size { get; set; }
//    }

//    [DataContract]
//    public class Thumb
//    {
//        public string file_id { get; set; }
//        public long width { get; set; }
//        public long height { get; set; }
//        public long file_size { get; set; }
//    }

//    [DataContract]
//    public class Document
//    {
//        public string file_id { get; set; }
//        public Thumb thumb { get; set; }
//        public string file_name { get; set; }
//        public string mime_type { get; set; }
//        public long file_size { get; set; }
//    }

//    [DataContract]
//    public class Photo
//    {
//        public string file_id { get; set; }
//        public long width { get; set; }
//        public long height { get; set; }
//        public long file_size { get; set; }
//    }

//    [DataContract]
//    public class Sticker
//    {
//        public string file_id { get; set; }
//        public string width { get; set; }
//        public string height { get; set; }
//        public Thumb thumb { get; set; }
//        public long file_size { get; set; }
//    }

//    [DataContract]
//    public class Video
//    {
//        public string file_id { get; set; }
//        public long width { get; set; }
//        public long height { get; set; }
//        public long duration { get; set; }
//        public Thumb thumb { get; set; }
//        public string mime_type { get; set; }
//        public long file_size { get; set; }
//    }

//    [DataContract]
//    public class Voice
//    {
//        public string file_id { get; set; }
//        public long duration { get; set; }
//        public string mime_type { get; set; }
//        public long file_size { get; set; }
//    }

//    [DataContract]
//    public class Contact
//    {
//        public string phone_number { get; set; }
//        public string first_name { get; set; }
//        public string last_name { get; set; }
//        public long user_id { get; set; }
//    }

//    [DataContract]
//    public class Location
//    {
//        public double longitude { get; set; }
//        public double latitude { get; set; }
//    }

//    [DataContract]
//    public class NewChatParticipant
//    {
//        public long id { get; set; }
//        public string first_name { get; set; }
//        public string last_name { get; set; }
//        public string username { get; set; }
//    }

//    [DataContract]
//    public class LeftChatParticipant
//    {
//        public long id { get; set; }
//        public string first_name { get; set; }
//        public string last_name { get; set; }
//        public string username { get; set; }
//    }

//    [DataContract]
//    public class NewChatPhoto
//    {
//        public string file_id { get; set; }
//        public long width { get; set; }
//        public long height { get; set; }
//        public long file_size { get; set; }
//    }

//    [DataContract]
//    public class ReplyToMessage
//    {
//        public long message_id { get; set; }
//        public User from { get; set; }
//        public long date { get; set; }
//        public Chat chat { get; set; }
//        public ForwardFrom forward_from { get; set; }
//        public long forward_date { get; set; }
//        public object reply_to_message { get; set; }
//        public string text { get; set; }
//        public Audio audio { get; set; }
//        public Document document { get; set; }
//        public IList<Photo> photo { get; set; }
//        public Sticker sticker { get; set; }
//        public Video video { get; set; }
//        public Voice voice { get; set; }
//        public string caption { get; set; }
//        public Contact contact { get; set; }
//        public Location location { get; set; }
//        public NewChatParticipant new_chat_participant { get; set; }
//        public LeftChatParticipant left_chat_participant { get; set; }
//        public string new_chat_title { get; set; }
//        public IList<NewChatPhoto> new_chat_photo { get; set; }
//        public bool delete_chat_photo { get; set; }
//        public bool group_chat_created { get; set; }
//    }

//    [DataContract]
//    public class Message
//    {
//        [DataMember]
//        public long message_id { get; set; }
//        [DataMember]
//        public User from { get; set; }
//        [DataMember]
//        public long date { get; set; }
//        [DataMember]
//        public Chat chat { get; set; }
//        [DataMember]
//        public User forward_from { get; set; }
//        [DataMember]
//        public Chat forward_from_chat { get; set; }
//        [DataMember]
//        public long forward_date { get; set; }
//        [DataMember]
//        public ReplyToMessage reply_to_message { get; set; }
//        [DataMember]
//        public string text { get; set; }
//        [DataMember]
//        public Audio audio { get; set; }
//        [DataMember]
//        public Document document { get; set; }
//        [DataMember]
//        public IList<Photo> photo { get; set; }
//        [DataMember]
//        public Sticker sticker { get; set; }
//        [DataMember]
//        public Video video { get; set; }
//        [DataMember]
//        public Voice voice { get; set; }
//        [DataMember]
//        public string caption { get; set; }
//        [DataMember]
//        public Contact contact { get; set; }
//        [DataMember]
//        public Location location { get; set; }
//        [DataMember]
//        public NewChatParticipant new_chat_participant { get; set; }
//        [DataMember]
//        public LeftChatParticipant left_chat_participant { get; set; }
//        [DataMember]
//        public string new_chat_title { get; set; }
//        [DataMember]
//        public IList<NewChatPhoto> new_chat_photo { get; set; }
//        [DataMember]
//        public bool delete_chat_photo { get; set; }
//        [DataMember]
//        public bool group_chat_created { get; set; }
//    }

//    [DataContract]
//    public class InlineQuery
//    {
//        [DataMember]
//        public string id { get; set; }
//        [DataMember]
//        public User from { get; set; }
//        [DataMember]
//        public Location location { get; set; }
//        [DataMember]
//        public string query { get; set; }
//        [DataMember]
//        public string offset { get; set; }
//    }

//    [DataContract]
//    public class Update
//    {
//        [DataMember]
//        public int id { get; set; }
//        [DataMember]
//        public Message message { get; set; }
//        [DataMember]
//        public Message edited_message { get; set; }
//        [DataMember]
//        public Message channel_post { get; set; }
//        [DataMember]
//        public Message edited_channel_post { get; set; }
//        [DataMember]
//        public InlineQuery inline_query { get; set; }
//        [DataMember]
//        public ChosenInlineResult chosen_inline_result { get; set; }
//        [DataMember]
//        public CallbackQuery callback_query { get; set; }
//        //[DataMember]
//        //public ShippingQuery shipping_query { get; set; }
//        //[DataMember]
//        //public PreCheckoutQuery pre_checkout_query { get; set; }
//    }

//    [DataContract]
//    public class CallbackQuery
//    {
//        [DataMember]
//        public string id { get; set; }
//        [DataMember]
//        public User from { get; set; }
//        [DataMember]
//        public Message message { get; set; }
//        [DataMember]
//        public string inline_message_id { get; set; }
//        [DataMember]
//        public string chat_instance { get; set; }
//        [DataMember]
//        public string data { get; set; }
//        [DataMember]
//        public string game_short_name { get; set; }
//    }

//    [DataContract]
//    public class ChosenInlineResult
//    {
//        [DataMember]
//        public string result_id { get; set; }
//        [DataMember]
//        public User from { get; set; }
//        [DataMember]
//        public Location location { get; set; }
//        [DataMember]
//        public string inline_message_id { get; set; }
//        [DataMember]
//        public string query { get; set; }
//    }
//}
