using System;
using AprenderIA.Domain.Entities;

namespace AprenderIA.Domain.IRepositorys;

public interface IPracticeQuizRepository
{
//we use the material id to get the quiz because we are interested in the material, not in the Quiz itself, and the quiz is always vinculated to a material
Task <ICollection<PracticeQuiz>> GetPracticeQuizzesAsync(CancellationToken ct=default);
Task<PracticeQuiz?> GetPracticeQuizAsync(Guid idMaterial, CancellationToken ct=default);
Task<bool> ExistByMaterialIdAsync(Guid idMaterial, CancellationToken ct=default);

Task CreatePracticeQuizAsync(PracticeQuiz practiceQuiz, CancellationToken ct=default);
Task UpdatePracticeQuizAsync(PracticeQuiz practiceQuiz, CancellationToken ct=default);
Task DeletePracticeQuizAsync(PracticeQuiz practiceQuiz, CancellationToken ct=default);

Task<ICollection<QuizQuestions>> GetQuizQuestionsByPracticeQuizIdAsync(Guid practiceQuizId, CancellationToken ct=default);
Task AddQuizQuestionAsync(QuizQuestions quizQuestion, CancellationToken ct=default);

}
