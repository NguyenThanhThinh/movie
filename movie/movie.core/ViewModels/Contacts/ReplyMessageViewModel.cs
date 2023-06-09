﻿using System.ComponentModel.DataAnnotations;

namespace movie.core.ViewModels.Contacts;

using static data.Constants.ValidationConstants;
using static ErrorMessages;

public class ReplyMessageViewModel
{
    public int Id { get; set; }

    [Required]
    [StringLength(MaxAdminName, MinimumLength = MinAdminName, ErrorMessage = NameError)]
    public string Name { get; set; } = null!;

    [Required] 
    [EmailAddress]
    public string AdminEmail { get; set; } = null!;

    [Required]
    [EmailAddress]
    public string ToUserEmail { get; set; } = null!;

    [Required]
    [StringLength(MaxSubjectLength, MinimumLength = MinSubjectLength, ErrorMessage = SubjectContactError)]
    public string Subject { get; set; } = null!;

    [Required]
    [StringLength(MaxMessageLength, MinimumLength = MinMessageLength, ErrorMessage = MessageError)]
    public string Message { get; set; } = null!;
}