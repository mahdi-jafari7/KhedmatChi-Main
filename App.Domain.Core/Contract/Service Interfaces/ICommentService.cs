﻿using App.Domain.Core.Customer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Services
{
    public interface ICommentService
    {
        public Task<Customer.Entities.Comment> CreateComment(CommentDto commentDto, CancellationToken cancellationToken);
        public Task<CommentDto> UpdateComment(CommentDto commentDto, CancellationToken cancellationToken);
        public Task<CommentSoftDeleteDto> SoftDeleteComment(int commentId, CancellationToken cancellationToken);
        //public Task<Customer.Entities.Comment> HardDeleteComment(int commentId, CancellationToken cancellationToken);
        public Task<CommentDto> GetCommentById(int commentId, CancellationToken cancellationToken);
        public Task<List<CommentDto>> GetComments(CancellationToken cancellationToken);
        public Task<CommentDto> ConfirmComment(int commentId, CancellationToken cancellationToken);
        public Task<List<CommentDto>> GetCommentsByExpertId(int expertId, int onlineCutomerId, CancellationToken cancellationToken);
      
        public Task<CommentDto> GetCustomerCommentByServiceRequestId(int customerId, int serviceRequestId, CancellationToken cancellationToken);

        public Task<List<CommentDto>> GetCommentsByExpertIdAsync(int expertId);

    }
}
