namespace AggregateSource.Repositories
{
    /// <summary>
    /// Represents a virtual collection of <typeparamref name="TAggregateRoot"/> for a particular tenant.
    /// </summary>
    /// <typeparam name="TAggregateRoot">The type of the aggregate root in this collection.</typeparam>
    internal interface IStatelessTenantRepository<TAggregateRoot>
    {
        /// <summary>
        /// Gets the aggregate root entity associated with the specified aggregate identifier.
        /// </summary>
        /// <param name="tenant">The tenant.</param>
        /// <param name="identifier">The aggregate identifier.</param>
        /// <returns>An instance of <typeparamref name="TAggregateRoot"/>.</returns>
        /// <exception cref="AggregateNotFoundException">Thrown when an aggregate is not found.</exception>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get")]
        TAggregateRoot Get(string tenant, string identifier);

        /// <summary>
        /// Gets the aggregate root entity associated with the specified aggregate identifier.
        /// </summary>
        /// <param name="tenant">The tenant.</param>
        /// <param name="identifier">The aggregate identifier.</param>
        /// <param name="version">The aggregate version.</param>
        /// <returns>An instance of <typeparamref name="TAggregateRoot"/>.</returns>
        /// <exception cref="AggregateNotFoundException">Thrown when an aggregate is not found.</exception>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get")]
        TAggregateRoot GetAt(string tenant, string identifier, int version);

        /// <summary>
        /// Attempts to get the aggregate root entity associated with the aggregate identifier.
        /// </summary>
        /// <param name="tenant">The tenant.</param>
        /// <param name="identifier">The aggregate identifier.</param>
        /// <returns>The found <typeparamref name="TAggregateRoot"/>, or empty if not found.</returns>
        Optional<TAggregateRoot> GetOptional(string tenant, string identifier);

        /// <summary>
        /// Attempts to get the aggregate root entity associated with the aggregate identifier.
        /// </summary>
        /// <param name="tenant">The tenant.</param>
        /// <param name="identifier">The aggregate identifier.</param>
        /// <param name="version">The aggregate version.</param>
        /// <returns>The found <typeparamref name="TAggregateRoot"/>, or empty if not found.</returns>
        Optional<TAggregateRoot> GetOptionalAt(string tenant, string identifier, int version);
    }
}