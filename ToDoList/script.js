const addBtn = document.getElementById("addBtn");
const taskInput = document.getElementById("taskInput");
const taskList = document.getElementById("taskList");
const taskCount = document.getElementById("taskCount");

loadTasks();

taskInput.addEventListener("keypress", (event) => {

    if (event.key === "Enter") {
        addBtn.click();
    }

});

addBtn.addEventListener("click", () => {

    const taskText = taskInput.value.trim();

    if (taskText === "") {
        alert("Please enter a task");
        return;
    }

    addTask(taskText);

    saveTasks();

    updateTaskCount();

    taskInput.value = "";
});

function addTask(taskText) {

    const li = document.createElement("li");

    const taskSpan = document.createElement("span");
    taskSpan.textContent = taskText;

    taskSpan.addEventListener("click", () => {

        taskSpan.classList.toggle("completed");

        saveTasks();
    });

    const deleteBtn = document.createElement("button");

    deleteBtn.textContent = "Delete";

    deleteBtn.addEventListener("click", () => {

        li.remove();

        saveTasks();

        updateTaskCount();
    });

    li.appendChild(taskSpan);

    li.appendChild(deleteBtn);

    taskList.appendChild(li);
}

function saveTasks() {

    const tasks = [];

    document.querySelectorAll("#taskList li span").forEach(task => {

        tasks.push({
            text: task.textContent,
            completed: task.classList.contains("completed")
        });

    });

    localStorage.setItem("tasks", JSON.stringify(tasks));
}

function loadTasks() {

    const tasks =
        JSON.parse(localStorage.getItem("tasks")) || [];

    tasks.forEach(task => {

        addTask(task.text);

        const lastTask =
            taskList.lastElementChild.querySelector("span");

        if (task.completed) {
            lastTask.classList.add("completed");
        }

    });

    updateTaskCount();
}

function updateTaskCount() {

    const totalTasks =
        document.querySelectorAll("#taskList li").length;

    taskCount.textContent =
        `Total Tasks: ${totalTasks}`;
}