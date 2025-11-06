
using System;
using System.Text;
using System.Collections.Generic;
using NeuralPlayGen.ApplicationCore.Exceptions;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CEN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.Utils;



namespace NeuralPlayGen.ApplicationCore.CP.NeuralPlay
{
public partial class ComunidadCP : GenericBasicCP
{
public ComunidadCP(GenericSessionCP currentSession)
        : base (currentSession)
{
}

public ComunidadCP(GenericSessionCP currentSession, GenericUnitOfWorkUtils unitUtils)
        : base (currentSession, unitUtils)
{
}
}
}
