
using System;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CP.NeuralPlay;

namespace NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay
{
public partial interface IReaccionRepository
{
void setSessionCP (GenericSessionCP session);

ReaccionEN ReadOIDDefault (int id
                           );

void ModifyDefault (ReaccionEN reaccion);

System.Collections.Generic.IList<ReaccionEN> ReadAllDefault (int first, int size);



int New_ (ReaccionEN reaccion);

void Modify (ReaccionEN reaccion);


void Destroy (int id
              );


ReaccionEN ReadOID (int id
                    );


System.Collections.Generic.IList<ReaccionEN> ReadAll (int first, int size);
}
}
