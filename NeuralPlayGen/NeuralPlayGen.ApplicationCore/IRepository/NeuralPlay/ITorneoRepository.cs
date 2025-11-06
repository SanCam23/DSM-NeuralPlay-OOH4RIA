
using System;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CP.NeuralPlay;

namespace NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay
{
public partial interface ITorneoRepository
{
void setSessionCP (GenericSessionCP session);

TorneoEN ReadOIDDefault (int id
                         );

void ModifyDefault (TorneoEN torneo);

System.Collections.Generic.IList<TorneoEN> ReadAllDefault (int first, int size);



int New_ (TorneoEN torneo);

void Modify (TorneoEN torneo);


void Destroy (int id
              );


TorneoEN ReadOID (int id
                  );


System.Collections.Generic.IList<TorneoEN> ReadAll (int first, int size);


System.Collections.Generic.IList<NeuralPlayGen.ApplicationCore.EN.NeuralPlay.TorneoEN> DameTorneosPorEquipo (int ? t_idEquipo);
}
}
