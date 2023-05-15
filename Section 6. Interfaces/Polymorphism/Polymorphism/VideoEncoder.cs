﻿namespace Polymorphism;

public class VideoEncoder
{
    private readonly MailService _mailService;

    public VideoEncoder()
    {
        _mailService = new MailService();
    }

    public void Encode(Video video)
    {
        // Implementation of video encoding logic
        // ...

        _mailService.Send(new Mail());
    }
}