// Sample student data (replace with actual data source or API call in a real application)
const studentData = {
    "S12345": {
        name: "Seshu",
        marks: {
            mathematics: 85,
            science: 92,
            english: 78,
            history: 88
        }
    },
    "S67890": {
        name: "vinay",
        marks: {
            mathematics: 70,
            science: 65,
            english: 82,
            history: 75
        }
    },
    "S13579": {
        name: "vamshi",
        marks: {
            mathematics: 95,
            science: 89,
            english: 91,
            history: 93
        }
    }
};

// Get DOM elements
const studentIdInput = document.getElementById('studentId');
const checkMarksBtn = document.getElementById('checkMarksBtn');
const marksDisplayDiv = document.getElementById('marksDisplay');
const errorMessageDiv = document.getElementById('errorMessage');

const studentNameDisplay = document.getElementById('studentNameDisplay');
const mathMarksSpan = document.getElementById('mathMarks');
const scienceMarksSpan = document.getElementById('scienceMarks');
const englishMarksSpan = document.getElementById('englishMarks');
const historyMarksSpan = document.getElementById('historyMarks');
const totalMarksSpan = document.getElementById('totalMarks');
const percentageSpan = document.getElementById('percentage');


function fetchMarks() {
    const studentId = studentIdInput.value.trim().toUpperCase();

    // Clear previous results and errors
    marksDisplayDiv.style.display = 'none';
    errorMessageDiv.style.display = 'none';
    errorMessageDiv.textContent = '';
    studentIdInput.style.borderColor = '#ddd'; // Reset border color

    if (studentId === "") {
        errorMessageDiv.textContent = "Please enter your Student ID.";
        errorMessageDiv.style.display = 'block';
        studentIdInput.style.borderColor = '#e74c3c';
        return;
    }

    const student = studentData[studentId];

    if (student) {
        studentNameDisplay.textContent = `Marks for: ${student.name}`;
        mathMarksSpan.textContent = student.marks.mathematics;
        scienceMarksSpan.textContent = student.marks.science;
        englishMarksSpan.textContent = student.marks.english;
        historyMarksSpan.textContent = student.marks.history;

        const totalMarks = student.marks.mathematics + student.marks.science + student.marks.english + student.marks.history;
        const numberOfSubjects = Object.keys(student.marks).length;
        const percentage = ((totalMarks / (numberOfSubjects * 100)) * 100).toFixed(2);

        totalMarksSpan.textContent = totalMarks;
        percentageSpan.textContent = `${percentage}%`;

        marksDisplayDiv.style.display = 'block';
    } else {
        errorMessageDiv.textContent = "Invalid Student ID. Please try again. (e.g. S12345, S67890, S13579)";
        errorMessageDiv.style.display = 'block';
        studentIdInput.style.borderColor = '#e74c3c';
    }
}

// Add event listener to the button
if (checkMarksBtn) {
    checkMarksBtn.addEventListener('click', fetchMarks);
}

// Optional: Allow pressing Enter in the input field to trigger the search
if (studentIdInput) {
    studentIdInput.addEventListener('keypress', function(event) {
        if (event.key === 'Enter') {
            event.preventDefault();
            fetchMarks();
        }
    });
}