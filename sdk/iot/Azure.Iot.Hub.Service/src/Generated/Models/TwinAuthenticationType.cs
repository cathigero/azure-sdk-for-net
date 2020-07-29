// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The authentication type used by the device. </summary>
    public readonly partial struct TwinAuthenticationType : IEquatable<TwinAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="TwinAuthenticationType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TwinAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SasValue = "sas";
        private const string SelfSignedValue = "selfSigned";
        private const string CertificateAuthorityValue = "certificateAuthority";
        private const string NoneValue = "none";

        /// <summary> sas. </summary>
        public static TwinAuthenticationType Sas { get; } = new TwinAuthenticationType(SasValue);
        /// <summary> selfSigned. </summary>
        public static TwinAuthenticationType SelfSigned { get; } = new TwinAuthenticationType(SelfSignedValue);
        /// <summary> certificateAuthority. </summary>
        public static TwinAuthenticationType CertificateAuthority { get; } = new TwinAuthenticationType(CertificateAuthorityValue);
        /// <summary> none. </summary>
        public static TwinAuthenticationType None { get; } = new TwinAuthenticationType(NoneValue);
        /// <summary> Determines if two <see cref="TwinAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(TwinAuthenticationType left, TwinAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TwinAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(TwinAuthenticationType left, TwinAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TwinAuthenticationType"/>. </summary>
        public static implicit operator TwinAuthenticationType(string value) => new TwinAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TwinAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TwinAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
