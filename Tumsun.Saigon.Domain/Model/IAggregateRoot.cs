using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tumsun.Saigon.Domain.Model
{
    /// <summary>
    /// Defines an entity type that can be an aggregate root
    /// </summary>
    public interface IAggregateRoot
    {
        /// <summary>
        /// Gets wether the current aggregate can be saved
        /// </summary>
        bool CanBeSaved { get; }

        /// <summary>
        /// Gets wether the current aggregate can be deleted
        /// </summary>
        bool CanBeDeleted { get; }
    }
}
