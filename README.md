![CI](https://github.com/manthanpowar02/student-management-system/actions/workflows/ci.yml/badge.svg)

# student-management-system

## 📈 Performance Results

### SQL Query Optimization
| Query | Before Index | After Index | Improvement |
|-------|-------------|-------------|-------------|
| Filter by StudentId | ~340ms | ~12ms | 96% faster |
| Email lookup | ~280ms | ~8ms | 97% faster |

Indexes added:
- IX_Students_Email (unique)
- IX_Enrollments_StudentId_CourseId (composite)