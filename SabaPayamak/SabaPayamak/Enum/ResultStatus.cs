using System.ComponentModel;

namespace SabaPayamak.Enum
{
    public enum ResultStatus
    {
        [Description("با موفقیت ارسال شد")]
        Ok = 0,
        [Description("شماره گیرنده نادرست است")]
        InvalidReciver = 1,
        [Description("شماره فرستنده نادرست است")]
        InvalidSender = 2,
        [Description("پارامتر انکودینگ نامعتبر است")]
        InvalidEncodeing = 3,
        [Description("پارامتر mclass نامعتبر است")]
        InvalidMClass = 4,
        [Description("پارامتر UDH نامعتبر است")]
        InvalidUDH = 6,
        [Description("محتویات پیامک خالی است")]
        InvalidText = 13,
        [Description("مانده اعتبار ریالی مورد نیاز برای ارسال پیامک کافی نیست")]
        NoCharge = 14,
        [Description("سرور در هنگام ارسال پیام مشغول بر طرف نمودن ایراد داخلی بوده است")]
        ServerBusy = 15,
        [Description("حساب غیر فعال است")]
        DisabledAccount = 16,
        [Description("حساب منقضی شده است")]
        ExpireAccount = 17,
        [Description("نام کاربری و یا کلمه عبور نا معتبر است")]
        InvalidUserOrPass = 18,
        [Description("درخواست معتبر نیست")]
        InvalidRequest = 19,
        [Description("شماره فرستنده به حساب تعلق ندارد")]
        InvalidSenderError = 20,
        [Description("این سرویس برای حساب فعال نشده است")]
        AccessFaild = 22,
        [Description("در حال حاضر امکان پردازش درخواست جدید وجود ندارد،لطفا دوباره سعی کنید")]
        RetryAgain = 23,
        [Description("شناسه پیامک نا معتبر است")]
        InvalidUID = 24,
        [Description("نام متد درخواستی معتبر نیست")]
        InvalidMethod = 25,
        [Description("شماره گیرنده در لیست سیاه اپراتور قرار دارد")]
        BlackList = 27,
        [Description("شماره گیرنده بر اساس پیش شماره در حال حاضر در مگفا مسدود است")]
        PreNumberBlocked = 28,
        [Description("آدرس IP مبدا، اجازه دسترسی به این سرویس را ندارد")]
        InvalidIP = 29,
        [Description("تعداد بخش‌های پیامک بیش از حد مجاز استاندارد (۲۶۵ عدد) است")]
        InvalidMessagePart = 30,
        [Description("طول آرايه پارامتر messageBodies با طول آرايه گيرندگان تطابق ندارد")]
        InvalidMessageBodies = 101,
        [Description("طول آرايه پارامتر messageClass با طول آرايه گيرندگان تطابق ندارد")]
        InvalidMessageClass = 102,
        [Description("طول آرايه پارامتر senderNumbers با طول آرايه گيرندگان تطابق ندارد")]
        InvalidSenderNumbers = 103,
        [Description("طول آرايه پارامتر udhs با طول آرايه گيرندگان تطابق ندارد")]
        InvalidUDHs = 104,
        [Description("طول آرايه پارامتر priorities با طول آرايه گيرندگان تطابق ندارد")]
        InvalidPriorities = 105,
        [Description("آرايه‌ی گيرندگان خالی است")]
        InvalidRecipents = 106,
        [Description("طول آرايه پارامتر گيرندگان بيشتر از طول مجاز است")]
        InvalidParameter = 107,
        [Description("آرايه‌ی فرستندگان خالی است")]
        InvalidSenders = 108,
        [Description("طول آرايه پارامتر encoding با طول آرايه گيرندگان تطابق ندارد")]
        InvalidEncodings = 109,
        [Description("طول آرايه پارامتر checkingMessageIds با طول آرايه گيرندگان تطابق ندارد")]
        InvalidCheckingMessageIds = 110,
        [Description("کلید امنیتی شما با موفقیت ایجاد شد")]
        SuccessToken = 1001,
        [Description("داده ای وجود ندارد")]
        NoContent = 1002,
        [Description("خطایی اتفاق افتاده است،لطفا با پشتیبانی تماس بگیرید")]
        Exception = 500,
        [Description("کلید امنیتی شما منقضی شده یا  اشتباه است")]
        Unathorize = 401,
        [Description("نام کاربری یا رمز عبور اشتباه است")]
        UserOrPasswordWrong = 4001,
        [Description("شما نمیتوانید از طریق این دامنه درخواست بدهید")]
        DomainWrong = 4002,
        [Description("شماره ارسال اشتباه است")]
        VnumerWrong = 4003,
        [Description("وضعیت شماره ارسال مناسب ارسال نیست")]
        VnumerStatusWrong = 4004
    }
}
